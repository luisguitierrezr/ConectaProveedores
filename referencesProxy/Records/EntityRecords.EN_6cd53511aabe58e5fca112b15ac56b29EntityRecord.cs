using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] SpecialWorkflowUploadPuestos (jVj3+C1WqkqGPW83EdagDQ)
///  <code>EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord</code> that represent
/// s <code>SpecialWorkflowUploadPuestos</code> <p>Description: Special Workflow Upload Puestos</p>
/// </summary>
// Name: SpecialWorkflowUploadPuestos
public partial struct EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord : ITypedRecord<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*_LVN4lMcDUmgwSXZBI2fFA");
internal static readonly GlobalObjectKey IdSpecialWorkflowId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*33+Udl3DqUSOqS2Th7Na2A");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*qaYHL6Rx40GVZVjl8+r9aw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

private long _ssSpecialWorkflowId;
public long ssSpecialWorkflowId{
  get{
      return _ssSpecialWorkflowId;
  }
  set{
      if((_ssSpecialWorkflowId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSpecialWorkflowId = value;
      }
  }
}

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssEntraRoleId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssSpecialWorkflowId = 0L;
_ssEntraRoleId = 0L;
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
ssId = r.ReadLongInteger(index++, "SpecialWorkflowUploadPuestos.Id", 0L);
ssSpecialWorkflowId = r.ReadEntityReferenceLongInteger(index++, "SpecialWorkflowUploadPuestos.SpecialWorkflowId", 0L);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "SpecialWorkflowUploadPuestos.EntraRoleId", 0L);
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord r) {
this = r;
}


public static bool operator == (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord a, EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSpecialWorkflowId != b.ssSpecialWorkflowId) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
return true;
}

public static bool operator != (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord a, EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord)) return false;
return (this == (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSpecialWorkflowId.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord Duplicate() {
EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord t;
t._ssId = this._ssId;
t._ssSpecialWorkflowId = this._ssSpecialWorkflowId;
t._ssEntraRoleId = this._ssEntraRoleId;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
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
} else if (head == "specialworkflowid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialWorkflowId")) variable.Value = ssSpecialWorkflowId; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSpecialWorkflowId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSpecialWorkflowId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSpecialWorkflowId) {
return ssSpecialWorkflowId;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSpecialWorkflowId.Key.AsGuid) {
return ssSpecialWorkflowId;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSpecialWorkflowId = (long) other.AttributeGet(IdSpecialWorkflowId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSpecialWorkflowId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSpecialWorkflowId);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdEntraRoleId);
}
} // EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord

/// <summary>
/// RecordList type <code>SpecialWorkflowUploadPuestosList</code> that represents a record list of
///  <code>SpecialWorkflowUploadPuestos</code>
/// </summary>
public partial class RL_0f3dc127d011bd572e591be80fd1c281 : GenericRecordList<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord>, IEnumerable, IEnumerator {

protected override EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord GetElementDefaultValue() {
return new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord();
}

public T[] ToArray<T>(Func<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0f3dc127d011bd572e591be80fd1c281 recordList, Func<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0f3dc127d011bd572e591be80fd1c281(EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord[] array) {
  RL_0f3dc127d011bd572e591be80fd1c281 result = new RL_0f3dc127d011bd572e591be80fd1c281();
result.InnerFromArray(array);
    return result;
}

public static RL_0f3dc127d011bd572e591be80fd1c281 ToList<T>(T[] array, Func <T, EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> converter) {
  RL_0f3dc127d011bd572e591be80fd1c281 result = new RL_0f3dc127d011bd572e591be80fd1c281();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0f3dc127d011bd572e591be80fd1c281 FromRestList<T>(RestList<T> restList, Func <T, EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> converter) {
  RL_0f3dc127d011bd572e591be80fd1c281 result = new RL_0f3dc127d011bd572e591be80fd1c281();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0f3dc127d011bd572e591be80fd1c281() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> NewList() {
return new RL_0f3dc127d011bd572e591be80fd1c281();
}


} // RL_0f3dc127d011bd572e591be80fd1c281
}
