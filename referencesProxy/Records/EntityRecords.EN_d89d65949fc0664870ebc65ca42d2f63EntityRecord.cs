using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] ManualFile (qE2PL6zL_kSz4MImjocSQQ)
///  <code>EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord</code> that represent
/// s <code>ManualFile</code> <p>Description: Manual File</p>
/// </summary>
// Name: ManualFile
public partial struct EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord : ITypedRecord<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*flrCvQe1zEq7ZthiFVbKtA");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*oOaMYUX_ckKs_nhr6lIQUw");
internal static readonly GlobalObjectKey IdFile = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*VDGRDQQiqkqTlAP6HdCOlA");
internal static readonly GlobalObjectKey IdVideoLink = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*19w9Cwcc9UugHUmekonQzw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFilename = value;
      }
  }
}

private byte[] _ssFile;
public byte[] ssFile{
  get{
      return _ssFile;
  }
  set{
      if((_ssFile!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFile = value;
      }
  }
}

private string _ssVideoLink;
public string ssVideoLink{
  get{
      return _ssVideoLink;
  }
  set{
      if((_ssVideoLink!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssVideoLink = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssFilename = "";
_ssFile = new byte[] {};
_ssVideoLink = "";
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
ssId = r.ReadEntityReferenceLongInteger(index++, "ManualFile.Id", 0L);
ssFilename = r.ReadText(index++, "ManualFile.Filename", "");
ssFile = r.ReadBinaryData(index++, "ManualFile.File", new byte[] {});
ssVideoLink = r.ReadText(index++, "ManualFile.VideoLink", "");
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord r) {
this = r;
}


public static bool operator == (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord a, EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssFile, b.ssFile)) return false;
if (a.ssVideoLink != b.ssVideoLink) return false;
return true;
}

public static bool operator != (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord a, EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord)) return false;
return (this == (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssFile.GetHashCode()
 ^ ssVideoLink.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord Duplicate() {
EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord t;
t._ssId = this._ssId;
t._ssFilename = this._ssFilename;
t._ssFile = this._ssFile;
t._ssVideoLink = this._ssVideoLink;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "file") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".File")) variable.Value = ssFile; else variable.Optimized = true;
} else if (head == "videolink") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VideoLink")) variable.Value = ssVideoLink; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[1];
}
if (key.Equals(IdFile)) {
return ChangedAttributes[2];
}
if (key.Equals(IdVideoLink)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdFile)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdVideoLink)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdFile) {
return ssFile;
}
if (key == IdVideoLink) {
return ssVideoLink;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdFile.Key.AsGuid) {
return ssFile;
}
if (attributeKey == IdVideoLink.Key.AsGuid) {
return ssVideoLink;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFilename);
ssFile = (byte[]) other.AttributeGet(IdFile);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFile);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFile);
ssVideoLink = (string) other.AttributeGet(IdVideoLink);
ChangedAttributes[3] = other.ChangedAttributeGet(IdVideoLink);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdVideoLink);
}
} // EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord

/// <summary>
/// RecordList type <code>ManualFileList</code> that represents a record list of
///  <code>ManualFile</code>
/// </summary>
public partial class RL_6ceaa20e65da2fc23629c7aa9dbff2c7 : GenericRecordList<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord GetElementDefaultValue() {
return new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord();
}

public T[] ToArray<T>(Func<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6ceaa20e65da2fc23629c7aa9dbff2c7 recordList, Func<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6ceaa20e65da2fc23629c7aa9dbff2c7(EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord[] array) {
  RL_6ceaa20e65da2fc23629c7aa9dbff2c7 result = new RL_6ceaa20e65da2fc23629c7aa9dbff2c7();
result.InnerFromArray(array);
    return result;
}

public static RL_6ceaa20e65da2fc23629c7aa9dbff2c7 ToList<T>(T[] array, Func <T, EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> converter) {
  RL_6ceaa20e65da2fc23629c7aa9dbff2c7 result = new RL_6ceaa20e65da2fc23629c7aa9dbff2c7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6ceaa20e65da2fc23629c7aa9dbff2c7 FromRestList<T>(RestList<T> restList, Func <T, EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> converter) {
  RL_6ceaa20e65da2fc23629c7aa9dbff2c7 result = new RL_6ceaa20e65da2fc23629c7aa9dbff2c7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6ceaa20e65da2fc23629c7aa9dbff2c7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> NewList() {
return new RL_6ceaa20e65da2fc23629c7aa9dbff2c7();
}


} // RL_6ceaa20e65da2fc23629c7aa9dbff2c7
}
