﻿using System;
using System.Collections.Generic;
using CSC.CSClassroom.Model.Projects;
using CSC.CSClassroom.Model.Projects.ServiceResults;
using CSC.CSClassroom.WebApp.Extensions;
using CSC.CSClassroom.WebApp.Providers;
using CSC.CSClassroom.WebApp.ViewHelpers.NestedTables;
using Newtonsoft.Json;

namespace CSC.CSClassroom.WebApp.ViewModels.Submission
{
	/// <summary>
	/// A table entry for a past submission.
	/// </summary>
	public class PastSubmissionTableEntry : SubmissionTableEntry
	{
		/// <summary>
		/// The checkpoint name.
		/// </summary>
		[TableColumn("Checkpoint Name")]
		public string CheckpointName { get; set; }

		/// <summary>
		/// The date of the submission.
		/// </summary>
		[TableColumn("Date Committed")]
		public string DateCommitted { get; set; }

		/// <summary>
		/// The status of the submission.
		/// </summary>
		[TableColumn("Submission Status")]
		public string SubmissionStatus { get; }

		/// <summary>
		/// The date of the submission.
		/// </summary>
		[TableColumn("Pull Request")]
		public string PullRequest { get; set; }
		
		/// <summary>
		/// The feedback for the submission.
		/// </summary>
		[TableOptions(ShowHeader = false)]
		[SubTable(typeof(PastSubmissionFeedback))]
		[JsonProperty(PropertyName = "childTableData")]
		public List<PastSubmissionFeedback> PastSubmissionFeedback { get; set; }

		/// <summary>
		/// Constructor.
		/// </summary>
		public PastSubmissionTableEntry(
			PastSubmissionResult result,
			Func<int, string> buildUrlBuilder,
			Func<Commit, int, string> pullRequestUrlBuilder,
			ITimeZoneProvider timeZoneProvider)
		{
			CheckpointName = result.CheckpointDisplayName;

			DateCommitted = GetLink
			(
				buildUrlBuilder(result.Build.Id),
				result.CommitDate.FormatShortDateTime(timeZoneProvider),
				preventWrapping: true
			);

			SubmissionStatus = GetSubmissionStatus(result.DaysLate);

			PullRequest = GetLink
			(
				pullRequestUrlBuilder(result.Build.Commit, result.PullRequestNumber.Value),
				"Pull Request",
				preventWrapping: true
			);

			PastSubmissionFeedback = new List<PastSubmissionFeedback>()
			{
				new PastSubmissionFeedback(result.Feedback)
			};
		}
	}
}
