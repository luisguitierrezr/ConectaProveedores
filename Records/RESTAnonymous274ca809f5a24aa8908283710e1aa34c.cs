using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM_CECORecord
public class RESTRC_5785ca28d1d4c2bc76a000f13481f797 : AbstractRESTStructure<RC_5785ca28d1d4c2bc76a000f13481f797> {
[JsonProperty("PI_ITEM_SM_CECO")]
public ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure AttrPI_ITEM_SM_CECO;

public RESTRC_5785ca28d1d4c2bc76a000f13481f797() { }

public RESTRC_5785ca28d1d4c2bc76a000f13481f797 (RC_5785ca28d1d4c2bc76a000f13481f797 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM_CECO = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM_CECO, new ST_1241dbde99de907a27732884f6e65ab4Structure(), ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure.FromStructure, config);
  } else {
AttrPI_ITEM_SM_CECO = ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure.FromStructure(s.ssSTPI_ITEM_SM_CECO, config);
  }
}

public static RC_5785ca28d1d4c2bc76a000f13481f797 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5785ca28d1d4c2bc76a000f13481f797 obj) { 
  RC_5785ca28d1d4c2bc76a000f13481f797 s = new RC_5785ca28d1d4c2bc76a000f13481f797();
  if(obj != null) {
  s.ssSTPI_ITEM_SM_CECO = ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure.ToStructure(obj.AttrPI_ITEM_SM_CECO);
  }
  return s;
}

public static Func<RC_5785ca28d1d4c2bc76a000f13481f797, ssConectaProveedores.RestRecords.RESTRC_5785ca28d1d4c2bc76a000f13481f797> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5785ca28d1d4c2bc76a000f13481f797 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5785ca28d1d4c2bc76a000f13481f797 FromStructure(RC_5785ca28d1d4c2bc76a000f13481f797 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5785ca28d1d4c2bc76a000f13481f797(s, config);
}

}


