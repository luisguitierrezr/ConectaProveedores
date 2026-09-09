using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryOrderRequestUpdateRecord
public class RESTRC_3680fcc88ad001f8f5724e587c7c5ba6 : AbstractRESTStructure<RC_3680fcc88ad001f8f5724e587c7c5ba6> {
[JsonProperty("EntryOrderRequestUpdate")]
public ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure AttrEntryOrderRequestUpdate;

public RESTRC_3680fcc88ad001f8f5724e587c7c5ba6() { }

public RESTRC_3680fcc88ad001f8f5724e587c7c5ba6 (RC_3680fcc88ad001f8f5724e587c7c5ba6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntryOrderRequestUpdate = ConvertToRestWithoutDefaults(s.ssSTEntryOrderRequestUpdate, new ST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure(), ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure.FromStructure, config);
  } else {
AttrEntryOrderRequestUpdate = ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure.FromStructure(s.ssSTEntryOrderRequestUpdate, config);
  }
}

public static RC_3680fcc88ad001f8f5724e587c7c5ba6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3680fcc88ad001f8f5724e587c7c5ba6 obj) { 
  RC_3680fcc88ad001f8f5724e587c7c5ba6 s = new RC_3680fcc88ad001f8f5724e587c7c5ba6();
  if(obj != null) {
  s.ssSTEntryOrderRequestUpdate = ssConectaProveedores.RestRecords.RESTST_2f2ec31e2efdad4ee20db1f76bfc2aa4Structure.ToStructure(obj.AttrEntryOrderRequestUpdate);
  }
  return s;
}

public static Func<RC_3680fcc88ad001f8f5724e587c7c5ba6, ssConectaProveedores.RestRecords.RESTRC_3680fcc88ad001f8f5724e587c7c5ba6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3680fcc88ad001f8f5724e587c7c5ba6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3680fcc88ad001f8f5724e587c7c5ba6 FromStructure(RC_3680fcc88ad001f8f5724e587c7c5ba6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3680fcc88ad001f8f5724e587c7c5ba6(s, config);
}

}


