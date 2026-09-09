using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationFilesRecord
public class RESTRC_dac4d0b34831478d401f08fdebfad1b4 : AbstractRESTStructure<RC_dac4d0b34831478d401f08fdebfad1b4> {
[JsonProperty("DocumentExtrationFiles")]
public ssConectaProveedores.RestRecords.RESTST_27be19a2068bdbf4844f837df703a71bStructure AttrDocumentExtrationFiles;

public RESTRC_dac4d0b34831478d401f08fdebfad1b4() { }

public RESTRC_dac4d0b34831478d401f08fdebfad1b4 (RC_dac4d0b34831478d401f08fdebfad1b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationFiles = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationFiles, new ST_27be19a2068bdbf4844f837df703a71bStructure(), ssConectaProveedores.RestRecords.RESTST_27be19a2068bdbf4844f837df703a71bStructure.FromStructure, config);
  } else {
AttrDocumentExtrationFiles = ssConectaProveedores.RestRecords.RESTST_27be19a2068bdbf4844f837df703a71bStructure.FromStructure(s.ssSTDocumentExtrationFiles, config);
  }
}

public static RC_dac4d0b34831478d401f08fdebfad1b4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dac4d0b34831478d401f08fdebfad1b4 obj) { 
  RC_dac4d0b34831478d401f08fdebfad1b4 s = new RC_dac4d0b34831478d401f08fdebfad1b4();
  if(obj != null) {
  s.ssSTDocumentExtrationFiles = ssConectaProveedores.RestRecords.RESTST_27be19a2068bdbf4844f837df703a71bStructure.ToStructure(obj.AttrDocumentExtrationFiles);
  }
  return s;
}

public static Func<RC_dac4d0b34831478d401f08fdebfad1b4, ssConectaProveedores.RestRecords.RESTRC_dac4d0b34831478d401f08fdebfad1b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dac4d0b34831478d401f08fdebfad1b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dac4d0b34831478d401f08fdebfad1b4 FromStructure(RC_dac4d0b34831478d401f08fdebfad1b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dac4d0b34831478d401f08fdebfad1b4(s, config);
}

}


