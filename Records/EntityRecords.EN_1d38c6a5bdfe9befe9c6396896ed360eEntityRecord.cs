using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] File3 (Vob4q9FhEk6C0S+mGlvUew)
///  <code>EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord</code> that represents <code>File3</code
/// > <p>Description: Entity that holds binaries files.</p>
/// </summary>
// Name: File3
public partial struct EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord : ITypedRecord<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PBNJ2DboLk2VJ4SuQo2QTw");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XYoHDu6ZPk+jX1KYy_SLhA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*q9GRstrNmk6_dN7VXP7OKA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OwP4vBIu6UiqSi7bMFa6qQ");

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

private byte[] _ssBinary;
public byte[] ssBinary{
  get{
      return _ssBinary;
  }
  set{
      if((_ssBinary!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssBinary = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCreatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssBinary = new byte[] {};
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "File3.Id", 0L);
ssBinary = r.ReadBinaryData(index++, "File3.Binary", new byte[] {});
ssCreatedBy = r.ReadEntityReferenceText(index++, "File3.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "File3.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord r) {
this = r;
}


public static bool operator == (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord a, EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord a, EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord)) return false;
return (this == (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssBinary.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord Duplicate() {
EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord t;
t._ssId = this._ssId;
t._ssBinary = this._ssBinary;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
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
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdBinary)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdBinary)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdBinary) {
return ssBinary;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
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
ssBinary = (byte[]) other.AttributeGet(IdBinary);
ChangedAttributes[1] = other.ChangedAttributeGet(IdBinary);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdBinary);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
}
} // EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord

/// <summary>
/// RecordList type <code>File3List</code> that represents a record list of <code>File3</code>
/// </summary>
public partial class RL_a2d3d64deee85b99341d990c79d22298 : GenericRecordList<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord GetElementDefaultValue() {
return new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord();
}

public T[] ToArray<T>(Func<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a2d3d64deee85b99341d990c79d22298 recordList, Func<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a2d3d64deee85b99341d990c79d22298(EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord[] array) {
  RL_a2d3d64deee85b99341d990c79d22298 result = new RL_a2d3d64deee85b99341d990c79d22298();
result.InnerFromArray(array);
    return result;
}

public static RL_a2d3d64deee85b99341d990c79d22298 ToList<T>(T[] array, Func <T, EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> converter) {
  RL_a2d3d64deee85b99341d990c79d22298 result = new RL_a2d3d64deee85b99341d990c79d22298();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a2d3d64deee85b99341d990c79d22298 FromRestList<T>(RestList<T> restList, Func <T, EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> converter) {
  RL_a2d3d64deee85b99341d990c79d22298 result = new RL_a2d3d64deee85b99341d990c79d22298();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a2d3d64deee85b99341d990c79d22298() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord> NewList() {
return new RL_a2d3d64deee85b99341d990c79d22298();
}


} // RL_a2d3d64deee85b99341d990c79d22298
}
