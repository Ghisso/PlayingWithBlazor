//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace PlayingWithBlazor.Models
{
    public class MelbourneHousePricesInput
    {
        [ColumnName("Suburb"), LoadColumn(0)]
        public string Suburb { get; set; }


        [ColumnName("Address"), LoadColumn(1)]
        public string Address { get; set; }


        [ColumnName("Rooms"), LoadColumn(2)]
        public float Rooms { get; set; }


        [ColumnName("Type"), LoadColumn(3)]
        public string Type { get; set; }


        [ColumnName("Price"), LoadColumn(4)]
        public float Price { get; set; }


        [ColumnName("Method"), LoadColumn(5)]
        public string Method { get; set; }


        [ColumnName("SellerG"), LoadColumn(6)]
        public string SellerG { get; set; }


        [ColumnName("Date"), LoadColumn(7)]
        public string Date { get; set; }


        [ColumnName("Distance"), LoadColumn(8)]
        public float Distance { get; set; }


        [ColumnName("Postcode"), LoadColumn(9)]
        public float Postcode { get; set; }


        [ColumnName("Bedroom2"), LoadColumn(10)]
        public float Bedroom2 { get; set; }


        [ColumnName("Bathroom"), LoadColumn(11)]
        public float Bathroom { get; set; }


        [ColumnName("Car"), LoadColumn(12)]
        public float Car { get; set; }


        [ColumnName("Landsize"), LoadColumn(13)]
        public float Landsize { get; set; }


        [ColumnName("BuildingArea"), LoadColumn(14)]
        public float BuildingArea { get; set; }


        [ColumnName("YearBuilt"), LoadColumn(15)]
        public float YearBuilt { get; set; }


        [ColumnName("CouncilArea"), LoadColumn(16)]
        public string CouncilArea { get; set; }


        [ColumnName("Regionname"), LoadColumn(17)]
        public string Regionname { get; set; }


        [ColumnName("Propertycount"), LoadColumn(18)]
        public float Propertycount { get; set; }
    }
}
