using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalCommentFile (v_SpzTBXxEiueJkFhUJIrQ)
///  <code>EN_7db82b55fc996c1dcfda575a9310d307EntityRecord</code> that represent
/// s <code>ProposalCommentFile</code> <p>Description: Entity that holds the Comments Files.</p>
/// </summary>
// Name: ProposalCommentFile
public partial struct EN_7db82b55fc996c1dcfda575a9310d307EntityRecord : ITypedRecord<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XQlVPFN0gUmPyBoXA9N7ZQ");
internal static readonly GlobalObjectKey IdCommentId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_HM4xbh55UGnXWiYFInkDg");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qdyehU42hEOy0XyBZj1d+g");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VvUncA+Bh0+FahupO+IR8w");

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

private long _ssCommentId;
public long ssCommentId{
  get{
      return _ssCommentId;
  }
  set{
      if((_ssCommentId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCommentId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFilename = value;
      }
  }
}

private byte[] _ssBinary;
public byte[] ssBinary{
  get{
      return _ssBinary;
  }
  set{
      if((_ssBinary!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssBinary = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7db82b55fc996c1dcfda575a9310d307EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssCommentId = 0L;
_ssFilename = "";
_ssBinary = new byte[] {};
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
ssId = r.ReadLongInteger(index++, "ProposalCommentFile.Id", 0L);
ssCommentId = r.ReadEntityReferenceLongInteger(index++, "ProposalCommentFile.CommentId", 0L);
ssFilename = r.ReadText(index++, "ProposalCommentFile.Filename", "");
ssBinary = r.ReadBinaryData(index++, "ProposalCommentFile.Binary", new byte[] {});
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
public void ReadIM(EN_7db82b55fc996c1dcfda575a9310d307EntityRecord r) {
this = r;
}


public static bool operator == (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord a, EN_7db82b55fc996c1dcfda575a9310d307EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCommentId != b.ssCommentId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
return true;
}

public static bool operator != (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord a, EN_7db82b55fc996c1dcfda575a9310d307EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord)) return false;
return (this == (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCommentId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssBinary.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7db82b55fc996c1dcfda575a9310d307EntityRecord Duplicate() {
EN_7db82b55fc996c1dcfda575a9310d307EntityRecord t;
t._ssId = this._ssId;
t._ssCommentId = this._ssCommentId;
t._ssFilename = this._ssFilename;
t._ssBinary = this._ssBinary;
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
} else if (head == "commentid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentId")) variable.Value = ssCommentId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdCommentId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[2];
}
if (key.Equals(IdBinary)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCommentId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdBinary)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCommentId) {
return ssCommentId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdBinary) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdCommentId.Key.AsGuid) {
return ssCommentId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
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
ssCommentId = (long) other.AttributeGet(IdCommentId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCommentId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCommentId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFilename);
ssBinary = (byte[]) other.AttributeGet(IdBinary);
ChangedAttributes[3] = other.ChangedAttributeGet(IdBinary);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdBinary);
}
} // EN_7db82b55fc996c1dcfda575a9310d307EntityRecord

/// <summary>
/// RecordList type <code>ProposalCommentFileList</code> that represents a record list of
///  <code>ProposalCommentFile</code>
/// </summary>
public partial class RL_f73ba846284347c6782120d3afae9cae : GenericRecordList<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord>, IEnumerable, IEnumerator {

protected override EN_7db82b55fc996c1dcfda575a9310d307EntityRecord GetElementDefaultValue() {
return new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord();
}

public T[] ToArray<T>(Func<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f73ba846284347c6782120d3afae9cae recordList, Func<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f73ba846284347c6782120d3afae9cae(EN_7db82b55fc996c1dcfda575a9310d307EntityRecord[] array) {
  RL_f73ba846284347c6782120d3afae9cae result = new RL_f73ba846284347c6782120d3afae9cae();
result.InnerFromArray(array);
    return result;
}

public static RL_f73ba846284347c6782120d3afae9cae ToList<T>(T[] array, Func <T, EN_7db82b55fc996c1dcfda575a9310d307EntityRecord> converter) {
  RL_f73ba846284347c6782120d3afae9cae result = new RL_f73ba846284347c6782120d3afae9cae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f73ba846284347c6782120d3afae9cae FromRestList<T>(RestList<T> restList, Func <T, EN_7db82b55fc996c1dcfda575a9310d307EntityRecord> converter) {
  RL_f73ba846284347c6782120d3afae9cae result = new RL_f73ba846284347c6782120d3afae9cae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f73ba846284347c6782120d3afae9cae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord> NewList() {
return new RL_f73ba846284347c6782120d3afae9cae();
}


} // RL_f73ba846284347c6782120d3afae9cae
}
