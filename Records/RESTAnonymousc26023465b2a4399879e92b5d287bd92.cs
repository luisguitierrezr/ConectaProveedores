using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_CECO_COSMOZREspRecord
public class RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6 : AbstractRESTStructure<RC_4b9181ec00d2ca6b946c45d8bcadc2a6> {
[JsonProperty("ZMXMIMMF_EM_SM_CECO_COSMOZREsp")]
public ssConectaProveedores.RestRecords.RESTST_ecd8bf4dc0f110548ef2317e70fd4c61Structure AttrZMXMIMMF_EM_SM_CECO_COSMOZREsp;

public RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6() { }

public RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6 (RC_4b9181ec00d2ca6b946c45d8bcadc2a6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_CECO_COSMOZREsp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp, new ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure(), ssConectaProveedores.RestRecords.RESTST_ecd8bf4dc0f110548ef2317e70fd4c61Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_CECO_COSMOZREsp = ssConectaProveedores.RestRecords.RESTST_ecd8bf4dc0f110548ef2317e70fd4c61Structure.FromStructure(s.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp, config);
  }
}

public static RC_4b9181ec00d2ca6b946c45d8bcadc2a6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6 obj) { 
  RC_4b9181ec00d2ca6b946c45d8bcadc2a6 s = new RC_4b9181ec00d2ca6b946c45d8bcadc2a6();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp = ssConectaProveedores.RestRecords.RESTST_ecd8bf4dc0f110548ef2317e70fd4c61Structure.ToStructure(obj.AttrZMXMIMMF_EM_SM_CECO_COSMOZREsp);
  }
  return s;
}

public static Func<RC_4b9181ec00d2ca6b946c45d8bcadc2a6, ssConectaProveedores.RestRecords.RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4b9181ec00d2ca6b946c45d8bcadc2a6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6 FromStructure(RC_4b9181ec00d2ca6b946c45d8bcadc2a6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4b9181ec00d2ca6b946c45d8bcadc2a6(s, config);
}

}


