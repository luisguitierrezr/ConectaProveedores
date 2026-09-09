using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM_CECORecord
public class JSONRC_8d6c816cab3d04c045c6166095f12882 : AbstractRESTStructure<RC_8d6c816cab3d04c045c6166095f12882> {
[JsonProperty("PI_ITEM_EM_CECO")]
[JsonPropertyName("PI_ITEM_EM_CECO")]
public ssConectaProveedores.RestRecords.JSONST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure AttrPI_ITEM_EM_CECO;

public JSONRC_8d6c816cab3d04c045c6166095f12882() { }

public JSONRC_8d6c816cab3d04c045c6166095f12882 (RC_8d6c816cab3d04c045c6166095f12882 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM_CECO = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM_CECO, new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure(), ssConectaProveedores.RestRecords.JSONST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure.FromStructure, config);
  } else {
AttrPI_ITEM_EM_CECO = ssConectaProveedores.RestRecords.JSONST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure.FromStructure(s.ssSTPI_ITEM_EM_CECO, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8d6c816cab3d04c045c6166095f12882, RC_8d6c816cab3d04c045c6166095f12882> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8d6c816cab3d04c045c6166095f12882 s) => ToStructure(s, config);
}
public static RC_8d6c816cab3d04c045c6166095f12882 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8d6c816cab3d04c045c6166095f12882 obj, IBehaviorsConfiguration config) { 
  RC_8d6c816cab3d04c045c6166095f12882 s = new RC_8d6c816cab3d04c045c6166095f12882();
  if(obj != null) {
  s.ssSTPI_ITEM_EM_CECO = ssConectaProveedores.RestRecords.JSONST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure.ToStructure(obj.AttrPI_ITEM_EM_CECO, config);
  }
  return s;
}

public static Func<RC_8d6c816cab3d04c045c6166095f12882, ssConectaProveedores.RestRecords.JSONRC_8d6c816cab3d04c045c6166095f12882> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d6c816cab3d04c045c6166095f12882 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8d6c816cab3d04c045c6166095f12882 FromStructure(RC_8d6c816cab3d04c045c6166095f12882 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8d6c816cab3d04c045c6166095f12882(s, config);
}

}


