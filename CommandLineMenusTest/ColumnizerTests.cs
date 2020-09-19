using System;
using System.Collections.Generic;
using Xunit;
using CommandLineMenus;

namespace CommandLineMenusTest
{
    public class ColumnizerTests
    {
        [Fact]
        public void AcceptsSingleColumn()
        {
            List<ColumnSetting> columns = new List<ColumnSetting>();
            columns.Add(new ColumnSetting(1, ColumnJustification.Left));
            Columnizer test = new Columnizer(columns);
        }

        [Fact]
        public void AcceptSingleCharacterColumnWithText()
        {
            List<ColumnSetting> columns = new List<ColumnSetting>();
            columns.Add(new ColumnSetting(1, ColumnJustification.Left));
            Columnizer testColumnizer = new Columnizer(columns);

            string testInput = "abcde";
            List<string> expectedResult = new List<string>(){"a","b","c","d","e"};
            testColumnizer.AddRow(new List<string>() {testInput});

            List<string> testResult = testColumnizer.GenerateColumns();

            Assert.Equal(expectedResult, testResult);
        }

    }
}   
