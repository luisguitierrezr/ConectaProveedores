namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioQFiles (pFshy9PBJk6zrRR54iAvjA)
///  <code>ST_b9bc0a93e29018653085b5de5dd1951eStructure</code> that represents <code>FolioQFiles</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioQFiles
public partial struct ST_b9bc0a93e29018653085b5de5dd1951eStructure : ITypedRecord<ST_b9bc0a93e29018653085b5de5dd1951eStructure> {
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6ELeCKoLyUyMlC35avmL4Q");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3J5q38J_z0mxPRKX0tptQw");
internal static readonly GlobalObjectKey IdBinaryFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eDF1mxnSFkKim1k477fp6w");
internal static readonly GlobalObjectKey IdFileExists = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*akUJ3srWfEqStN_axHo3Fw");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6VZztrOkWEarq4ulAptMtA");

public string ssFilename;

public byte[] ssBinary;

public string ssBinaryFilename;

public bool ssFileExists;

public bool ssIsExtra;


public BitArray OptimizedAttributes;

public ST_b9bc0a93e29018653085b5de5dd1951eStructure() {
OptimizedAttributes = null;
ssFilename = "";
ssBinary = new byte[] {};
ssBinaryFilename = "";
ssFileExists = false;
ssIsExtra = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssFilename = r.ReadText(index++, "FolioQFiles.Filename", "");
ssBinary = r.ReadBinaryData(index++, "FolioQFiles.Binary", new byte[] {});
ssBinaryFilename = r.ReadText(index++, "FolioQFiles.BinaryFilename", "");
ssFileExists = r.ReadBoolean(index++, "FolioQFiles.FileExists", false);
ssIsExtra = r.ReadBoolean(index++, "FolioQFiles.IsExtra", false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_b9bc0a93e29018653085b5de5dd1951eStructure r) {
this = r;
}


public static bool operator == (ST_b9bc0a93e29018653085b5de5dd1951eStructure a, ST_b9bc0a93e29018653085b5de5dd1951eStructure b) {
if (a.ssFilename != b.ssFilename) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
if (a.ssBinaryFilename != b.ssBinaryFilename) return false;
if (a.ssFileExists != b.ssFileExists) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
return true;
}

public static bool operator != (ST_b9bc0a93e29018653085b5de5dd1951eStructure a, ST_b9bc0a93e29018653085b5de5dd1951eStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b9bc0a93e29018653085b5de5dd1951eStructure)) return false;
return (this == (ST_b9bc0a93e29018653085b5de5dd1951eStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssBinary.GetHashCode()
 ^ ssBinaryFilename.GetHashCode()
 ^ ssFileExists.GetHashCode()
 ^ ssIsExtra.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b9bc0a93e29018653085b5de5dd1951eStructure Duplicate() {
ST_b9bc0a93e29018653085b5de5dd1951eStructure t;
t.ssFilename = this.ssFilename;
t.ssBinary = this.ssBinary;
t.ssBinaryFilename = this.ssBinaryFilename;
t.ssFileExists = this.ssFileExists;
t.ssIsExtra = this.ssIsExtra;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
} else if (head == "binaryfilename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryFilename")) variable.Value = ssBinaryFilename; else variable.Optimized = true;
} else if (head == "fileexists") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileExists")) variable.Value = ssFileExists; else variable.Optimized = true;
} else if (head == "isextra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExtra")) variable.Value = ssIsExtra; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFilename) {
return ssFilename;
}
if (key == IdBinary) {
return ssBinary;
}
if (key == IdBinaryFilename) {
return ssBinaryFilename;
}
if (key == IdFileExists) {
return ssFileExists;
}
if (key == IdIsExtra) {
return ssIsExtra;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
}
if (attributeKey == IdBinaryFilename.Key.AsGuid) {
return ssBinaryFilename;
}
if (attributeKey == IdFileExists.Key.AsGuid) {
return ssFileExists;
}
if (attributeKey == IdIsExtra.Key.AsGuid) {
return ssIsExtra;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFilename = (string) other.AttributeGet(IdFilename);
ssBinary = (byte[]) other.AttributeGet(IdBinary);
ssBinaryFilename = (string) other.AttributeGet(IdBinaryFilename);
ssFileExists = (bool) other.AttributeGet(IdFileExists);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
}
} // ST_b9bc0a93e29018653085b5de5dd1951eStructure
/// <summary>
/// RecordList type <code>FolioQFilesList</code> that represents a record list of
///  <code>FolioQFiles</code>
/// </summary>
public partial class RL_d6af4e3a9c01393365c1248e2444fa63 : GenericRecordList<ST_b9bc0a93e29018653085b5de5dd1951eStructure>, IEnumerable, IEnumerator {

protected override ST_b9bc0a93e29018653085b5de5dd1951eStructure GetElementDefaultValue() {
return new ST_b9bc0a93e29018653085b5de5dd1951eStructure();
}

public T[] ToArray<T>(Func<ST_b9bc0a93e29018653085b5de5dd1951eStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d6af4e3a9c01393365c1248e2444fa63 recordList, Func<ST_b9bc0a93e29018653085b5de5dd1951eStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d6af4e3a9c01393365c1248e2444fa63(ST_b9bc0a93e29018653085b5de5dd1951eStructure[] array) {
  RL_d6af4e3a9c01393365c1248e2444fa63 result = new RL_d6af4e3a9c01393365c1248e2444fa63();
result.InnerFromArray(array);
    return result;
}

public static RL_d6af4e3a9c01393365c1248e2444fa63 ToList<T>(T[] array, Func <T, ST_b9bc0a93e29018653085b5de5dd1951eStructure> converter) {
  RL_d6af4e3a9c01393365c1248e2444fa63 result = new RL_d6af4e3a9c01393365c1248e2444fa63();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d6af4e3a9c01393365c1248e2444fa63 FromRestList<T>(RestList<T> restList, Func <T, ST_b9bc0a93e29018653085b5de5dd1951eStructure> converter) {
  RL_d6af4e3a9c01393365c1248e2444fa63 result = new RL_d6af4e3a9c01393365c1248e2444fa63();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d6af4e3a9c01393365c1248e2444fa63() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b9bc0a93e29018653085b5de5dd1951eStructure> NewList() {
return new RL_d6af4e3a9c01393365c1248e2444fa63();
}


} // RL_d6af4e3a9c01393365c1248e2444fa63
}

