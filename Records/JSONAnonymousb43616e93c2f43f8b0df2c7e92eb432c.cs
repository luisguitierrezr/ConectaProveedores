using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersImportRequestRecord
public class JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 : AbstractRESTStructure<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> {
[JsonProperty("OrdersImportRequest")]
[JsonPropertyName("OrdersImportRequest")]
public ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord AttrOrdersImportRequest;

public JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12() { }

public JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersImportRequest = ConvertToRestWithoutDefaults(s.ssENOrdersImportRequest, new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure, config);
  } else {
AttrOrdersImportRequest = ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure(s.ssENOrdersImportRequest, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12, RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s) => ToStructure(s, config);
}
public static RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 obj, IBehaviorsConfiguration config) { 
  RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s = new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12();
  if(obj != null) {
  s.ssENOrdersImportRequest = ssConectaProveedores.RestRecords.JSONEN_8c3668a93870461b8ea1216c2848f298EntityRecord.ToStructure(obj.AttrOrdersImportRequest, config);
  }
  return s;
}

public static Func<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12, ssConectaProveedores.RestRecords.JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 FromStructure(RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2407b5abb2cbfeaeaa8da6cdea4ccf12(s, config);
}

}


