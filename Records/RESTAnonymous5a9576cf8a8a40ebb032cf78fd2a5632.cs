using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OnPremisesExtensionAttributeRecord
public class RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb : AbstractRESTStructure<RC_8408d1f105e1ca6f4773d6dc694bb3bb> {
[JsonProperty("OnPremisesExtensionAttribute")]
public ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure AttrOnPremisesExtensionAttribute;

public RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb() { }

public RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb (RC_8408d1f105e1ca6f4773d6dc694bb3bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOnPremisesExtensionAttribute = ConvertToRestWithoutDefaults(s.ssSTOnPremisesExtensionAttribute, new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure(), ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure.FromStructure, config);
  } else {
AttrOnPremisesExtensionAttribute = ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure.FromStructure(s.ssSTOnPremisesExtensionAttribute, config);
  }
}

public static RC_8408d1f105e1ca6f4773d6dc694bb3bb ToStructure(ssConectaProveedores.RestRecords.RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb obj) { 
  RC_8408d1f105e1ca6f4773d6dc694bb3bb s = new RC_8408d1f105e1ca6f4773d6dc694bb3bb();
  if(obj != null) {
  s.ssSTOnPremisesExtensionAttribute = ssConectaProveedores.RestRecords.RESTST_f5088e93197e1d0bc0e83e9a247c44fbStructure.ToStructure(obj.AttrOnPremisesExtensionAttribute);
  }
  return s;
}

public static Func<RC_8408d1f105e1ca6f4773d6dc694bb3bb, ssConectaProveedores.RestRecords.RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8408d1f105e1ca6f4773d6dc694bb3bb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb FromStructure(RC_8408d1f105e1ca6f4773d6dc694bb3bb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8408d1f105e1ca6f4773d6dc694bb3bb(s, config);
}

}


