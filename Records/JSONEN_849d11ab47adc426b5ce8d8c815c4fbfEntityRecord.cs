using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Color
public class JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord : AbstractRESTStructure<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> {
[JsonProperty("Color")]
[JsonPropertyName("Color")]
public string AttrColor;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

public JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord() { }

public JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = s.ssColor;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrColor = s.ssColor;
AttrOrder = (int?) s.ssOrder;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s) => ToStructure(s, config);
}
public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s = new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "" : obj.AttrColor;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord, ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord FromStructure(EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord(s, config);
}

}


