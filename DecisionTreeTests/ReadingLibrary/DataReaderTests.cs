﻿using Decision_Tree_ALg.DataEntities;
using System.Collections.Generic;
using Decision_Tree_ALg.PrepareDataLib;
using System;
using Decision_Tree_ALg.Config;
using System.Reflection;
using NUnit.Framework;
using Decision_Tree_ALg.ReadingLibrary;

namespace DecisionTreeTests.ReadingLibrary
{
    [TestFixture]
    public class DataReaderTests
    {


        /// <summary>
        /// Testing ReturnAllExamplesFromFile method
        /// </summary>

        [TestCase(@"C:\Users\Ivan Grigorov\Desktop\DataExamples.txt", typeof(IDataEntity))]
        [TestCase(@"C: \Users\Ivan Grigorov\Desktop\DataExamples.txt", typeof(ADataEntity))]
        public void DataReader_ReturnAllExamplesFromFile_ShouldReturnArgumentExceptionWhenTypeIsInterfaceOrAbstractClass(string dataFilePath, Type typeOfClassToCreate)
        {
            // Arrange 
            // Act 
            // Arrange && Act && Assert 
            Assert.Throws<ArgumentException>(() => DataReader.ReturnAllExamplesFromFile(dataFilePath));
        }

        [TestCase(@"C:\Users\Ivan Grigorov\Desktop\DataExamples.txt", typeof(DataEntity))]
        public void DataReader_ReturnAllExamplesFromFile_ShouldNotThrowWhenTypeIsClass(string dataFilePath, Type typeOfClassToCreate)
        {
            // Arrange 
            // Act 
            // Arrange && Act && Assert 
            Assert.DoesNotThrow(() => DataReader.ReturnAllExamplesFromFile(dataFilePath));
        }

        [TestCase(@"C:\Users\Ivan Grigorov\Desktop\InvalidFile.txt", typeof(DataEntity))]
        public void DataReader_ReturnAllExamplesFromFile_ShouldThrowAnExceptionWhenPathIsInvalid(string dataFilePath, Type typeOfClassToCreate)
        {
            // Arrange 
            // Act 
            // Arrange && Act && Assert 
            Assert.Throws<System.IO.FileNotFoundException>(() => DataReader.ReturnAllExamplesFromFile(dataFilePath));
        }


        /// <summary>
        /// Testing ReturnAllExamplesFromEmbeddedRessource method
        /// </summary>

        [TestCase(typeof(IDataEntity))]
        [TestCase(typeof(ADataEntity))]
        public void DataReader_ReturnAllExamplesFromEmbeddedRessource_ShouldReturnArgumentExceptionWhenTypeIsInterfaceOrAbstractClass(Type typeOfClassToCreate)
        {
            // Arrange 
            // Act 
            // Arrange && Act && Assert 
            Assert.Throws<ArgumentException>(() => DataReader.ReturnAllExamplesFromEmbeddedRessource(typeOfClassToCreate));
        }

        [TestCase(typeof(DataEntity))]
        public void DataReader_ReturnAllExamplesFromEmbeddedRessource_ShouldNotThrowWhenTypeIsClass(Type typeOfClassToCreate)
        {
            // Arrange 
            // Act 
            // Arrange && Act && Assert 
            Assert.DoesNotThrow(() => DataReader.ReturnAllExamplesFromEmbeddedRessource(typeOfClassToCreate));
        }

    }
}