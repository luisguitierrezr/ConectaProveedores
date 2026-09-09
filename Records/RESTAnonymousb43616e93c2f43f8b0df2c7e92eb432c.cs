using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersImportRequestRecord
public class RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 : AbstractRESTStructure<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> {
[JsonProperty("OrdersImportRequest")]
public ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord AttrOrdersImportRequest;

public RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12() { }

public RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersImportRequest = ConvertToRestWithoutDefaults(s.ssENOrdersImportRequest, new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure, config);
  } else {
AttrOrdersImportRequest = ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.FromStructure(s.ssENOrdersImportRequest, config);
  }
}

public static RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 obj) { 
  RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s = new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12();
  if(obj != null) {
  s.ssENOrdersImportRequest = ssConectaProveedores.RestRecords.RESTEN_8c3668a93870461b8ea1216c2848f298EntityRecord.ToStructure(obj.AttrOrdersImportRequest);
  }
  return s;
}

public static Func<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12, ssConectaProveedores.RestRecords.RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12 FromStructure(RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2407b5abb2cbfeaeaa8da6cdea4ccf12(s, config);
}

}


