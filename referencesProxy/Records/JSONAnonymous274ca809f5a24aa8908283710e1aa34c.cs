using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_SM_CECORecord
public class JSONRC_5785ca28d1d4c2bc76a000f13481f797 : AbstractRESTStructure<RC_5785ca28d1d4c2bc76a000f13481f797> {
[JsonProperty("PI_ITEM_SM_CECO")]
[JsonPropertyName("PI_ITEM_SM_CECO")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure AttrPI_ITEM_SM_CECO;

public JSONRC_5785ca28d1d4c2bc76a000f13481f797() { }

public JSONRC_5785ca28d1d4c2bc76a000f13481f797 (RC_5785ca28d1d4c2bc76a000f13481f797 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM_CECO = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM_CECO, new ST_1241dbde99de907a27732884f6e65ab4Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure.FromStructure, config);
  } else {
AttrPI_ITEM_SM_CECO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure.FromStructure(s.ssSTPI_ITEM_SM_CECO, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5785ca28d1d4c2bc76a000f13481f797, RC_5785ca28d1d4c2bc76a000f13481f797> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5785ca28d1d4c2bc76a000f13481f797 s) => ToStructure(s, config);
}
public static RC_5785ca28d1d4c2bc76a000f13481f797 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5785ca28d1d4c2bc76a000f13481f797 obj, IBehaviorsConfiguration config) { 
  RC_5785ca28d1d4c2bc76a000f13481f797 s = new RC_5785ca28d1d4c2bc76a000f13481f797();
  if(obj != null) {
  s.ssSTPI_ITEM_SM_CECO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure.ToStructure(obj.AttrPI_ITEM_SM_CECO, config);
  }
  return s;
}

public static Func<RC_5785ca28d1d4c2bc76a000f13481f797, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5785ca28d1d4c2bc76a000f13481f797> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5785ca28d1d4c2bc76a000f13481f797 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5785ca28d1d4c2bc76a000f13481f797 FromStructure(RC_5785ca28d1d4c2bc76a000f13481f797 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5785ca28d1d4c2bc76a000f13481f797(s, config);
}

}


