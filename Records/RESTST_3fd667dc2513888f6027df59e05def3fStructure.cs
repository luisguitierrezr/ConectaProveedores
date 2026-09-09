using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Rows
public class RESTST_3fd667dc2513888f6027df59e05def3fStructure : AbstractRESTStructure<ST_3fd667dc2513888f6027df59e05def3fStructure> {
[JsonProperty("RowNumber")]
public long? AttrRowNumber;

[JsonProperty("Quantity")]
public decimal? AttrQuantity;

public RESTST_3fd667dc2513888f6027df59e05def3fStructure() { }

public RESTST_3fd667dc2513888f6027df59e05def3fStructure (ST_3fd667dc2513888f6027df59e05def3fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRowNumber = ConvertToRestWithoutDefaults(s.ssRowNumber, 0L);
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
  } else {
AttrRowNumber = (long?) s.ssRowNumber;
AttrQuantity = (decimal?) s.ssQuantity;
  }
}

public static ST_3fd667dc2513888f6027df59e05def3fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure obj) { 
  ST_3fd667dc2513888f6027df59e05def3fStructure s = new ST_3fd667dc2513888f6027df59e05def3fStructure();
  if(obj != null) {
  s.ssRowNumber = obj.AttrRowNumber == null ? 0L : obj.AttrRowNumber.Value;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  }
  return s;
}

public static Func<ST_3fd667dc2513888f6027df59e05def3fStructure, ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3fd667dc2513888f6027df59e05def3fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure FromStructure(ST_3fd667dc2513888f6027df59e05def3fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure(s, config);
}

}


