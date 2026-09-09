using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DeletedStorageRecord
public class JSONRC_1789507e695396bb66757dd83a78c4b5 : AbstractRESTStructure<RC_1789507e695396bb66757dd83a78c4b5> {
[JsonProperty("DeletedStorage")]
[JsonPropertyName("DeletedStorage")]
public ssConectaProveedores.RestRecords.JSONEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord AttrDeletedStorage;

public JSONRC_1789507e695396bb66757dd83a78c4b5() { }

public JSONRC_1789507e695396bb66757dd83a78c4b5 (RC_1789507e695396bb66757dd83a78c4b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDeletedStorage = ConvertToRestWithoutDefaults(s.ssENDeletedStorage, new EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord.FromStructure, config);
  } else {
AttrDeletedStorage = ssConectaProveedores.RestRecords.JSONEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord.FromStructure(s.ssENDeletedStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1789507e695396bb66757dd83a78c4b5, RC_1789507e695396bb66757dd83a78c4b5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1789507e695396bb66757dd83a78c4b5 s) => ToStructure(s, config);
}
public static RC_1789507e695396bb66757dd83a78c4b5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1789507e695396bb66757dd83a78c4b5 obj, IBehaviorsConfiguration config) { 
  RC_1789507e695396bb66757dd83a78c4b5 s = new RC_1789507e695396bb66757dd83a78c4b5();
  if(obj != null) {
  s.ssENDeletedStorage = ssConectaProveedores.RestRecords.JSONEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord.ToStructure(obj.AttrDeletedStorage, config);
  }
  return s;
}

public static Func<RC_1789507e695396bb66757dd83a78c4b5, ssConectaProveedores.RestRecords.JSONRC_1789507e695396bb66757dd83a78c4b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1789507e695396bb66757dd83a78c4b5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1789507e695396bb66757dd83a78c4b5 FromStructure(RC_1789507e695396bb66757dd83a78c4b5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1789507e695396bb66757dd83a78c4b5(s, config);
}

}


