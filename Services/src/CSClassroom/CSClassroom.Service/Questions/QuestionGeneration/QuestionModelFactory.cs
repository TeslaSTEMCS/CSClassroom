﻿using System.Collections.Generic;
using System.Reflection;
using CSC.CSClassroom.Model.Questions;

namespace CSC.CSClassroom.Service.Questions.QuestionGeneration
{
	/// <summary>
	/// Creates the question object model.
	/// </summary>
	public class QuestionModelFactory : IQuestionModelFactory
	{
		/// <summary>
		/// The Java code generation factory.
		/// </summary>
		private readonly IJavaCodeGenerationFactory _javaCodeGenFactory;

		/// <summary>
		/// Constructor.
		/// </summary>
		public QuestionModelFactory(IJavaCodeGenerationFactory javaCodeGenFactory)
		{
			_javaCodeGenFactory = javaCodeGenFactory;
		}

		/// <summary>
		/// Returns the question object model.
		/// </summary>
		public IList<JavaClass> GetQuestionModel()
		{
			return _javaCodeGenFactory.CreateBuilder(typeof(Question))

				// No meta-generated questions allowed
				.ExcludeType(typeof(GeneratedQuestionTemplate))

				// No code questions allowed
				.ExcludeType(typeof(CodeQuestion))

				// The question name can't vary with the seed
				.ExcludeProperties
				(
					prop => 
					   prop.DeclaringType == typeof(Question) 
					&& prop.Name == nameof(Question.Name)
				)

				// IDs are generated by the data layer
				.ExcludeProperties
				(
					prop => prop.Name.EndsWith("Id")
				)

				// Back references are automatically populated by the data layer
				.ExcludeProperties
				(
					prop => prop.DeclaringType.GetProperty($"{prop.Name}Id") != null
				)

				.Build();
		}
	}
}
