﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class TodoTaskTest
    {
        [TestMethod]
        public void Should_InstantiateTodoTask_Correctly()
        {
            TodoTask todoTask;
            int correctId = 0;
            string correctPriority = "HIGH";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(correctId, correctPriority, correctTitle, corectCreationTime);

            todoTask.Id.Should().Be(correctId);
            todoTask.Priority.Should().Be(correctPriority);
            todoTask.Title.Should().Be(correctTitle);
            todoTask.CreationTime.Should().Be(corectCreationTime);
        }

        [TestMethod]
        public void Should_UpdateConcludedPorcentage_WhenPorcentageSmallerThan100()
        {
            TodoTask todoTask;
            int percentage = 50;
            int correctId = 0;
            string correctPriority = "HIGH";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(correctId, correctPriority, correctTitle, corectCreationTime);
            todoTask.UpdatePercentageConcluded(percentage, DateTime.Now);

            todoTask.PercentageConcluded.Should().Be(percentage);
            todoTask.ConclusionTime.Should().BeNull();
        }

        [TestMethod]
        public void Should_UpdateConcludedPorcentageAndTime_WhenPorcentageBiggerThan99()
        {
            TodoTask todoTask;
            int percentage = 101;
            int correctId = 0;
            string correctPriority = "HIGH";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(correctId, correctPriority, correctTitle, corectCreationTime);
            todoTask.UpdatePercentageConcluded(percentage, DateTime.Now);

            todoTask.PercentageConcluded.Should().Be(100);
            todoTask.ConclusionTime.Should().NotBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowArgumentException_IdIsNegativeNumber()
        {
            TodoTask todoTask;
            int wrongId = -1;
            string correctPriority = "HIGH";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(wrongId, correctPriority, correctTitle, corectCreationTime);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowArgumentException_CreationTimeFromFuture()
        {
            TodoTask todoTask;
            int correctId = -1;
            string correctPriority = "HIGH";
            string correctTitle = "Test Task";
            DateTime wrongCreationTime = DateTime.Now.AddDays(100);

            todoTask = new TodoTask(correctId, correctPriority, correctTitle, wrongCreationTime);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowArgumentNullException_PriorityNullOrEmpty()
        {
            TodoTask todoTask;
            int correctId = 1;
            string wrongPriority = "";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(correctId, wrongPriority, correctTitle, corectCreationTime);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_ThrowArgumentNullException_TitleNullOrEmpty()
        {
            TodoTask todoTask;
            int correctId = 1;
            string correctPriority = "High";
            string wrongTitle = "";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(correctId, correctPriority, wrongTitle, corectCreationTime);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_ThrowArgumentException_PriorityIsInvalidString()
        {
            TodoTask todoTask;
            int correctId = 1;
            string wrongPriority = "Neither High, Medium or Low";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;

            todoTask = new TodoTask(correctId, wrongPriority, correctTitle, corectCreationTime);
        }
    }
}
