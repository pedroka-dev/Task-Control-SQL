using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskControlSql.ConsoleApp.Control;
using TaskControlSql.ConsoleApp.Domain;

namespace TaskControlSql.UnitTest
{
    [TestClass]
    public class TodoTaskControllerTest
    {
        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertNewTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime corectCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, corectCreationTime);
            taskController.DeleteAllEntities();
            string response = taskController.CreateEntity(todoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertInProgressTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            todoTask.UpdatePercentageConcluded(50);
            string response = taskController.CreateEntity(todoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertConcludedTask()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            todoTask.UpdatePercentageConcluded(100);
            string response = taskController.CreateEntity(todoTask);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod]
        public void Should_ReturnOpSucess_OnInsertMultipleTasks()
        {
            int correctId = 0;
            string correctPriority = "High";
            string correctTitle = "Test Task";
            DateTime correctCreationTime = DateTime.Now;
            TodoTaskController taskController = new TodoTaskController();
            taskController.DeleteAllEntities();

            TodoTask todoTask1 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask2 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            TodoTask todoTask3 = new TodoTask(correctId, correctPriority, correctTitle, correctCreationTime);
            string response1 = taskController.CreateEntity(todoTask1);
            string response2 = taskController.CreateEntity(todoTask2);
            string response3 = taskController.CreateEntity(todoTask3);

            string expectedResponse = "OP_SUCCESS";
            Assert.AreEqual(expectedResponse, response1);
            Assert.AreEqual(expectedResponse, response2);
            Assert.AreEqual(expectedResponse, response3);
        }
    }
}
