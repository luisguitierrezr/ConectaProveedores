using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractStatusRecord
public class RESTRC_64894cdb6c46279b2d012a58a7771333 : AbstractRESTStructure<RC_64894cdb6c46279b2d012a58a7771333> {
[JsonProperty("ContractStatus")]
public ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord AttrContractStatus;

public RESTRC_64894cdb6c46279b2d012a58a7771333() { }

public RESTRC_64894cdb6c46279b2d012a58a7771333 (RC_64894cdb6c46279b2d012a58a7771333 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContractStatus = ConvertToRestWithoutDefaults(s.ssENContractStatus, new EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord.FromStructure, config);
  } else {
AttrContractStatus = ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord.FromStructure(s.ssENContractStatus, config);
  }
}

public static RC_64894cdb6c46279b2d012a58a7771333 ToStructure(ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333 obj) { 
  RC_64894cdb6c46279b2d012a58a7771333 s = new RC_64894cdb6c46279b2d012a58a7771333();
  if(obj != null) {
  s.ssENContractStatus = ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord.ToStructure(obj.AttrContractStatus);
  }
  return s;
}

public static Func<RC_64894cdb6c46279b2d012a58a7771333, ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_64894cdb6c46279b2d012a58a7771333 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333 FromStructure(RC_64894cdb6c46279b2d012a58a7771333 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333(s, config);
}

}


