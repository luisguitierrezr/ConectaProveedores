using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesTypeRecord
public class RESTRC_8bfcc1d381d104953fbf01fd54a56e45 : AbstractRESTStructure<RC_8bfcc1d381d104953fbf01fd54a56e45> {
[JsonProperty("SeriesType")]
public ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord AttrSeriesType;

public RESTRC_8bfcc1d381d104953fbf01fd54a56e45() { }

public RESTRC_8bfcc1d381d104953fbf01fd54a56e45 (RC_8bfcc1d381d104953fbf01fd54a56e45 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesType = ConvertToRestWithoutDefaults(s.ssENSeriesType, new EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord.FromStructure, config);
  } else {
AttrSeriesType = ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord.FromStructure(s.ssENSeriesType, config);
  }
}

public static RC_8bfcc1d381d104953fbf01fd54a56e45 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8bfcc1d381d104953fbf01fd54a56e45 obj) { 
  RC_8bfcc1d381d104953fbf01fd54a56e45 s = new RC_8bfcc1d381d104953fbf01fd54a56e45();
  if(obj != null) {
  s.ssENSeriesType = ssConectaProveedores.RestRecords.RESTEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord.ToStructure(obj.AttrSeriesType);
  }
  return s;
}

public static Func<RC_8bfcc1d381d104953fbf01fd54a56e45, ssConectaProveedores.RestRecords.RESTRC_8bfcc1d381d104953fbf01fd54a56e45> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8bfcc1d381d104953fbf01fd54a56e45 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8bfcc1d381d104953fbf01fd54a56e45 FromStructure(RC_8bfcc1d381d104953fbf01fd54a56e45 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8bfcc1d381d104953fbf01fd54a56e45(s, config);
}

}


