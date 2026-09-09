using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FAC_PAG_CAB_OutRecord
public class RESTRC_63089b8d4a985345e32fc40fca06b12a : AbstractRESTStructure<RC_63089b8d4a985345e32fc40fca06b12a> {
[JsonProperty("T_FAC_PAG_CAB_Out")]
public ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure AttrT_FAC_PAG_CAB_Out;

public RESTRC_63089b8d4a985345e32fc40fca06b12a() { }

public RESTRC_63089b8d4a985345e32fc40fca06b12a (RC_63089b8d4a985345e32fc40fca06b12a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FAC_PAG_CAB_Out = ConvertToRestWithoutDefaults(s.ssSTT_FAC_PAG_CAB_Out, new ST_27647b039a03d40c5b921de2dccb61f4Structure(), ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure.FromStructure, config);
  } else {
AttrT_FAC_PAG_CAB_Out = ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure.FromStructure(s.ssSTT_FAC_PAG_CAB_Out, config);
  }
}

public static RC_63089b8d4a985345e32fc40fca06b12a ToStructure(ssConectaProveedores.RestRecords.RESTRC_63089b8d4a985345e32fc40fca06b12a obj) { 
  RC_63089b8d4a985345e32fc40fca06b12a s = new RC_63089b8d4a985345e32fc40fca06b12a();
  if(obj != null) {
  s.ssSTT_FAC_PAG_CAB_Out = ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure.ToStructure(obj.AttrT_FAC_PAG_CAB_Out);
  }
  return s;
}

public static Func<RC_63089b8d4a985345e32fc40fca06b12a, ssConectaProveedores.RestRecords.RESTRC_63089b8d4a985345e32fc40fca06b12a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_63089b8d4a985345e32fc40fca06b12a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_63089b8d4a985345e32fc40fca06b12a FromStructure(RC_63089b8d4a985345e32fc40fca06b12a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_63089b8d4a985345e32fc40fca06b12a(s, config);
}

}


