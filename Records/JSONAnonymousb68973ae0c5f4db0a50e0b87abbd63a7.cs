using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioObservationsRecord
public class JSONRC_017cba02e4fd7f684606081b7269a26b : AbstractRESTStructure<RC_017cba02e4fd7f684606081b7269a26b> {
[JsonProperty("FolioObservations")]
[JsonPropertyName("FolioObservations")]
public ssConectaProveedores.RestRecords.JSONEN_171b22187ea6e4b12c9f086502740307EntityRecord AttrFolioObservations;

public JSONRC_017cba02e4fd7f684606081b7269a26b() { }

public JSONRC_017cba02e4fd7f684606081b7269a26b (RC_017cba02e4fd7f684606081b7269a26b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioObservations = ConvertToRestWithoutDefaults(s.ssENFolioObservations, new EN_171b22187ea6e4b12c9f086502740307EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_171b22187ea6e4b12c9f086502740307EntityRecord.FromStructure, config);
  } else {
AttrFolioObservations = ssConectaProveedores.RestRecords.JSONEN_171b22187ea6e4b12c9f086502740307EntityRecord.FromStructure(s.ssENFolioObservations, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_017cba02e4fd7f684606081b7269a26b, RC_017cba02e4fd7f684606081b7269a26b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_017cba02e4fd7f684606081b7269a26b s) => ToStructure(s, config);
}
public static RC_017cba02e4fd7f684606081b7269a26b ToStructure(ssConectaProveedores.RestRecords.JSONRC_017cba02e4fd7f684606081b7269a26b obj, IBehaviorsConfiguration config) { 
  RC_017cba02e4fd7f684606081b7269a26b s = new RC_017cba02e4fd7f684606081b7269a26b();
  if(obj != null) {
  s.ssENFolioObservations = ssConectaProveedores.RestRecords.JSONEN_171b22187ea6e4b12c9f086502740307EntityRecord.ToStructure(obj.AttrFolioObservations, config);
  }
  return s;
}

public static Func<RC_017cba02e4fd7f684606081b7269a26b, ssConectaProveedores.RestRecords.JSONRC_017cba02e4fd7f684606081b7269a26b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_017cba02e4fd7f684606081b7269a26b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_017cba02e4fd7f684606081b7269a26b FromStructure(RC_017cba02e4fd7f684606081b7269a26b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_017cba02e4fd7f684606081b7269a26b(s, config);
}

}


