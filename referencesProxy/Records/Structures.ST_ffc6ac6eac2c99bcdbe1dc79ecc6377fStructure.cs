namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] VideoCaptions (qbIjTuY8JEaBjdGTojzaow)
///  <code>ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure</code> that represent
/// s <code>VideoCaptions</code> <p>Description: Video captions information</p>
/// </summary>
// Name: VideoCaptions
public partial struct ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure : ITypedRecord<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> {
internal static readonly GlobalObjectKey IdLanguageCode = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*xSTaBpmToUGlOoLaeVgxDg");
internal static readonly GlobalObjectKey IdSourceFile = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*r5qQVngUBUKhaA07n208fg");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MtDQILjcTkKH8dnRQOE6yw");

public string ssLanguageCode;

public string ssSourceFile;

public string ssLabel;


public BitArray OptimizedAttributes;

public ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure() {
OptimizedAttributes = null;
ssLanguageCode = "";
ssSourceFile = "";
ssLabel = "";
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
ssLanguageCode = r.ReadText(index++, "VideoCaptions.LanguageCode", "");
ssSourceFile = r.ReadText(index++, "VideoCaptions.SourceFile", "");
ssLabel = r.ReadText(index++, "VideoCaptions.Label", "");
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
public void ReadIM(ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure r) {
this = r;
}


public static bool operator == (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure a, ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure b) {
if (a.ssLanguageCode != b.ssLanguageCode) return false;
if (a.ssSourceFile != b.ssSourceFile) return false;
if (a.ssLabel != b.ssLabel) return false;
return true;
}

public static bool operator != (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure a, ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure)) return false;
return (this == (ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLanguageCode.GetHashCode()
 ^ ssSourceFile.GetHashCode()
 ^ ssLabel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure Duplicate() {
ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure t;
t.ssLanguageCode = this.ssLanguageCode;
t.ssSourceFile = this.ssSourceFile;
t.ssLabel = this.ssLabel;
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
if (head == "languagecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LanguageCode")) variable.Value = ssLanguageCode; else variable.Optimized = true;
} else if (head == "sourcefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SourceFile")) variable.Value = ssSourceFile; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
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
if (key == IdLanguageCode) {
return ssLanguageCode;
}
if (key == IdSourceFile) {
return ssSourceFile;
}
if (key == IdLabel) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLanguageCode.Key.AsGuid) {
return ssLanguageCode;
}
if (attributeKey == IdSourceFile.Key.AsGuid) {
return ssSourceFile;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLanguageCode = (string) other.AttributeGet(IdLanguageCode);
ssSourceFile = (string) other.AttributeGet(IdSourceFile);
ssLabel = (string) other.AttributeGet(IdLabel);
}
} // ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure
/// <summary>
/// RecordList type <code>VideoCaptionsList</code> that represents a record list of
///  <code>VideoCaptions</code>
/// </summary>
public partial class RL_e76ce0f7deb6f6a812e61bd92e29120f : GenericRecordList<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure>, IEnumerable, IEnumerator {

protected override ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure GetElementDefaultValue() {
return new ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure();
}

public T[] ToArray<T>(Func<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e76ce0f7deb6f6a812e61bd92e29120f recordList, Func<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e76ce0f7deb6f6a812e61bd92e29120f(ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure[] array) {
  RL_e76ce0f7deb6f6a812e61bd92e29120f result = new RL_e76ce0f7deb6f6a812e61bd92e29120f();
result.InnerFromArray(array);
    return result;
}

public static RL_e76ce0f7deb6f6a812e61bd92e29120f ToList<T>(T[] array, Func <T, ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> converter) {
  RL_e76ce0f7deb6f6a812e61bd92e29120f result = new RL_e76ce0f7deb6f6a812e61bd92e29120f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e76ce0f7deb6f6a812e61bd92e29120f FromRestList<T>(RestList<T> restList, Func <T, ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> converter) {
  RL_e76ce0f7deb6f6a812e61bd92e29120f result = new RL_e76ce0f7deb6f6a812e61bd92e29120f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e76ce0f7deb6f6a812e61bd92e29120f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ffc6ac6eac2c99bcdbe1dc79ecc6377fStructure> NewList() {
return new RL_e76ce0f7deb6f6a812e61bd92e29120f();
}


} // RL_e76ce0f7deb6f6a812e61bd92e29120f
}

