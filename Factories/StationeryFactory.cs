using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Factories
{
    public class StationeryFactory
    {

        public static MsStationery CreateStationery(int StationeryID, string StationeryName, int StationeryPrice) {

            return new MsStationery()
            {
                StationeryID = StationeryID,
                StationeryName = StationeryName,
                StationeryPrice = StationeryPrice
            };

        }

    }
}