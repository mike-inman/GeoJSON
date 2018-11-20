using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// https://www.weather.gov/documentation/services-web-api

namespace GeoJSONWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {

    //    ' Find points by category and keyword
    //            ' GET api/pointsofinterest/find/{category}/{keyword}
    //            <Route("find/{category}/{keyword}")>
    //            <System.Web.Http.HttpGet>
    //            Public Function FindPoints(ByVal category As String, ByVal keyword As String) As IHttpActionResult
    //                ' Return result as GeoJSON format
    //                Dim geojson As New FeatureCollection
    //                geojson.type = "FeatureCollection"

    //                ' Retrieve POI data from source database
    //                Dim data As DataTable = GetPOIData()

    //                ' Unsanitize category name since it has special character not allowable by Web API
    //                category = category.Replace("-and-", "&")
    //                keyword = keyword.Replace("*", "%").Replace("(any)", "%")

    //                ' Perform data filtering
    //                Dim filterExpression As String = String.Format("CATEGORY = '{0}' AND NAME LIKE '%{1}%'", category.Trim(), keyword.Trim())
    //                Dim matchRows As DataRow() = data.Select(filterExpression)

    //                ' Add features to FeatureCollection GeoJSON object
    //                Dim rowCount As Integer = 0

    //                For Each row As DataRow In matchRows
    //                    Dim feature As New FeatureItem
    //                    feature.id = row("ID")
    //                    feature.type = FeatureItemType.Feature.ToString
    //                    feature.properties.Add("NAME", row("NAME"))
    //                    feature.properties.Add("CATEGORY", row("CATEGORY"))
    //                    feature.properties.Add("COLOR", row("COLOR"))
    //                    feature.geometry.type = FeatureGeometryType.Point.ToString
    //                    feature.geometry.coordinates = { row("X"), row("Y")}

    //    geojson.features.Add(feature)
    //Next

    //                Return Ok(geojson)
    //            End Function

    }
}





//The end result is the service returns data in GeoJSON format ready to be consumed by OpenLayers!
//                {
//	                "type": "FeatureCollection",
//	                "features": [{
//		                "id": "1167",
//		                "type": "Feature",
//		                "properties": {
//			                "NAME": "Cafe",
//			                "CATEGORY": "Eating&Drinking",
//			                "COLOR": "#58FA58"
//		                },
//		                "geometry": {
//			                "type": "Point",
//			                "coordinates": [-105.2471939,
//			                40.0149442]
//		                }
//	                },
//	                {
//		                "id": "1203",
//		                "type": "Feature",
//		                "properties": {
//			                "NAME": "Cafe",
//			                "CATEGORY": "Eating&Drinking",
//			                "COLOR": "#58FA58"
//		                },
//		                "geometry": {
//			                "type": "Point",
//			                "coordinates": [-105.11558,
//			                40.5730241]
//		                }
//	                }]
//                }
            