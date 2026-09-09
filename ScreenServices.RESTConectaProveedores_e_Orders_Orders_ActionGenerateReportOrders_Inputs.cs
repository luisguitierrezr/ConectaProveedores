using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Orders_Number")]
public string inParamOrders_Number;
[JsonProperty("Orders_OrderStatusId")]
public int? inParamOrders_OrderStatusId;
[JsonProperty("Orders_SupplierId")]
public long? inParamOrders_SupplierId;
[JsonProperty("Orders_DateFrom")]
public String inParamOrders_DateFrom;
[JsonProperty("Orders_DateTo")]
public String inParamOrders_DateTo;
[JsonProperty("Orders_RegionId")]
public long? inParamOrders_RegionId;
[JsonProperty("UserRegion")]
public long? inParamUserRegion;
[JsonProperty("IsAllRegions")]
public bool? inParamIsAllRegions;
[JsonProperty("SortClause")]
public string inParamSortClause;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Model ToModel() {ConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Model result = new ConectaProveedores_e_Orders_Orders_ActionGenerateReportOrders_Model();
result.inParamOrders_Number = inParamOrders_Number == null ? "" : inParamOrders_Number;
result.inParamOrders_OrderStatusId = inParamOrders_OrderStatusId == null ? 0 : inParamOrders_OrderStatusId.Value;
result.inParamOrders_SupplierId = inParamOrders_SupplierId == null ? 0L : inParamOrders_SupplierId.Value;
result.inParamOrders_DateFrom = inParamOrders_DateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParamOrders_DateFrom);
result.inParamOrders_DateTo = inParamOrders_DateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParamOrders_DateTo);
result.inParamOrders_RegionId = inParamOrders_RegionId == null ? 0L : inParamOrders_RegionId.Value;
result.inParamUserRegion = inParamUserRegion == null ? 0L : inParamUserRegion.Value;
result.inParamIsAllRegions = inParamIsAllRegions == null ? false : inParamIsAllRegions.Value;
result.inParamSortClause = inParamSortClause == null ? "" : inParamSortClause;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
