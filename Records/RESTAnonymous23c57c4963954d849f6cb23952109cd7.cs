using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersConceptOrderDetailAllFilesRecord
public class RESTRC_b64b49f04ca283a60f06aecf635b2100 : AbstractRESTStructure<RC_b64b49f04ca283a60f06aecf635b2100> {
[JsonProperty("OrdersConcept")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrdersConcept;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("AllFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure> AttrAllFiles;

public RESTRC_b64b49f04ca283a60f06aecf635b2100() { }

public RESTRC_b64b49f04ca283a60f06aecf635b2100 (RC_b64b49f04ca283a60f06aecf635b2100 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersConcept = ConvertToRestWithoutDefaults(s.ssENOrdersConcept, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrAllFiles = s.ssRLAllFiles.Length == 0 ? null : s.ssRLAllFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure>(ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.FromStructureDelegate(config));
  } else {
AttrOrdersConcept = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrdersConcept, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrAllFiles = s.ssRLAllFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure>(ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.FromStructureDelegate(config));
  }
}

public static RC_b64b49f04ca283a60f06aecf635b2100 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b64b49f04ca283a60f06aecf635b2100 obj) { 
  RC_b64b49f04ca283a60f06aecf635b2100 s = new RC_b64b49f04ca283a60f06aecf635b2100();
  if(obj != null) {
  s.ssENOrdersConcept = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrdersConcept);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  s.ssRLAllFiles = RL_3d745491e03d6d19ccc0e1b33a371ccc.FromRestList(obj.AttrAllFiles, ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.ToStructure);
  }
  return s;
}

public static Func<RC_b64b49f04ca283a60f06aecf635b2100, ssConectaProveedores.RestRecords.RESTRC_b64b49f04ca283a60f06aecf635b2100> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b64b49f04ca283a60f06aecf635b2100 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b64b49f04ca283a60f06aecf635b2100 FromStructure(RC_b64b49f04ca283a60f06aecf635b2100 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b64b49f04ca283a60f06aecf635b2100(s, config);
}

}


