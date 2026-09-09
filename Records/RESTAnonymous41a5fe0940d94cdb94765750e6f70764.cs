using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_RETENCIONES_Out3Record
public class RESTRC_09d830783dfe5460acbd192ac56050be : AbstractRESTStructure<RC_09d830783dfe5460acbd192ac56050be> {
[JsonProperty("TI_RETENCIONES_Out3")]
public ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure AttrTI_RETENCIONES_Out3;

public RESTRC_09d830783dfe5460acbd192ac56050be() { }

public RESTRC_09d830783dfe5460acbd192ac56050be (RC_09d830783dfe5460acbd192ac56050be s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_RETENCIONES_Out3 = ConvertToRestWithoutDefaults(s.ssSTTI_RETENCIONES_Out3, new ST_9fe56281b338f341e5bf9f16eeeff800Structure(), ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure.FromStructure, config);
  } else {
AttrTI_RETENCIONES_Out3 = ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure.FromStructure(s.ssSTTI_RETENCIONES_Out3, config);
  }
}

public static RC_09d830783dfe5460acbd192ac56050be ToStructure(ssConectaProveedores.RestRecords.RESTRC_09d830783dfe5460acbd192ac56050be obj) { 
  RC_09d830783dfe5460acbd192ac56050be s = new RC_09d830783dfe5460acbd192ac56050be();
  if(obj != null) {
  s.ssSTTI_RETENCIONES_Out3 = ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure.ToStructure(obj.AttrTI_RETENCIONES_Out3);
  }
  return s;
}

public static Func<RC_09d830783dfe5460acbd192ac56050be, ssConectaProveedores.RestRecords.RESTRC_09d830783dfe5460acbd192ac56050be> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_09d830783dfe5460acbd192ac56050be s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_09d830783dfe5460acbd192ac56050be FromStructure(RC_09d830783dfe5460acbd192ac56050be s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_09d830783dfe5460acbd192ac56050be(s, config);
}

}


