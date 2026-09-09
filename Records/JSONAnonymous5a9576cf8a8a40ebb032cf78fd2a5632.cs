using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OnPremisesExtensionAttributeRecord
public class JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb : AbstractRESTStructure<RC_8408d1f105e1ca6f4773d6dc694bb3bb> {
[JsonProperty("OnPremisesExtensionAttribute")]
[JsonPropertyName("OnPremisesExtensionAttribute")]
public ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure AttrOnPremisesExtensionAttribute;

public JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb() { }

public JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb (RC_8408d1f105e1ca6f4773d6dc694bb3bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOnPremisesExtensionAttribute = ConvertToRestWithoutDefaults(s.ssSTOnPremisesExtensionAttribute, new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure(), ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure.FromStructure, config);
  } else {
AttrOnPremisesExtensionAttribute = ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure.FromStructure(s.ssSTOnPremisesExtensionAttribute, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb, RC_8408d1f105e1ca6f4773d6dc694bb3bb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb s) => ToStructure(s, config);
}
public static RC_8408d1f105e1ca6f4773d6dc694bb3bb ToStructure(ssConectaProveedores.RestRecords.JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb obj, IBehaviorsConfiguration config) { 
  RC_8408d1f105e1ca6f4773d6dc694bb3bb s = new RC_8408d1f105e1ca6f4773d6dc694bb3bb();
  if(obj != null) {
  s.ssSTOnPremisesExtensionAttribute = ssConectaProveedores.RestRecords.JSONST_f5088e93197e1d0bc0e83e9a247c44fbStructure.ToStructure(obj.AttrOnPremisesExtensionAttribute, config);
  }
  return s;
}

public static Func<RC_8408d1f105e1ca6f4773d6dc694bb3bb, ssConectaProveedores.RestRecords.JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8408d1f105e1ca6f4773d6dc694bb3bb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb FromStructure(RC_8408d1f105e1ca6f4773d6dc694bb3bb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8408d1f105e1ca6f4773d6dc694bb3bb(s, config);
}

}


