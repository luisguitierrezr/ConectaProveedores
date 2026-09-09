using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BusinessValueCategoryRecord
public class RESTRC_c8382e0b08ee9d5965e5aae5b17d6261 : AbstractRESTStructure<RC_c8382e0b08ee9d5965e5aae5b17d6261> {
[JsonProperty("BusinessValueCategory")]
public ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord AttrBusinessValueCategory;

public RESTRC_c8382e0b08ee9d5965e5aae5b17d6261() { }

public RESTRC_c8382e0b08ee9d5965e5aae5b17d6261 (RC_c8382e0b08ee9d5965e5aae5b17d6261 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBusinessValueCategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueCategory, new EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure, config);
  } else {
AttrBusinessValueCategory = ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.FromStructure(s.ssENBusinessValueCategory, config);
  }
}

public static RC_c8382e0b08ee9d5965e5aae5b17d6261 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261 obj) { 
  RC_c8382e0b08ee9d5965e5aae5b17d6261 s = new RC_c8382e0b08ee9d5965e5aae5b17d6261();
  if(obj != null) {
  s.ssENBusinessValueCategory = ssConectaProveedores.RestRecords.RESTEN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord.ToStructure(obj.AttrBusinessValueCategory);
  }
  return s;
}

public static Func<RC_c8382e0b08ee9d5965e5aae5b17d6261, ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c8382e0b08ee9d5965e5aae5b17d6261 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261 FromStructure(RC_c8382e0b08ee9d5965e5aae5b17d6261 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261(s, config);
}

}


