//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace PlayingWithBlazor.Models
{
    public class UniqloStockInput
    {
        [ColumnName("Open"), LoadColumn(0)]
        public float Open { get; set; }


        [ColumnName("High"), LoadColumn(1)]
        public float High { get; set; }


        [ColumnName("Low"), LoadColumn(2)]
        public float Low { get; set; }


        [ColumnName("Close"), LoadColumn(3)]
        public float Close { get; set; }


        [ColumnName("Volume"), LoadColumn(4)]
        public float Volume { get; set; }


        [ColumnName("Year"), LoadColumn(5)]
        public float Year { get; set; }


        [ColumnName("Month"), LoadColumn(6)]
        public float Month { get; set; }


        [ColumnName("Day"), LoadColumn(7)]
        public float Day { get; set; }


    }
}
