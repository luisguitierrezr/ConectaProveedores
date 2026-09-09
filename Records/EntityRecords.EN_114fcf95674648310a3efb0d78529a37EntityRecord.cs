using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionCostCenter (kY+G2Gly4U+lhpihGTCjVA)
///  <code>EN_114fcf95674648310a3efb0d78529a37EntityRecord</code> that represent
/// s <code>RequisitionCostCenter</code> <p>Description: Entity that holds Requisition Cost Center.</p>
/// </summary>
// Name: RequisitionCostCenter
public partial struct EN_114fcf95674648310a3efb0d78529a37EntityRecord : ITypedRecord<EN_114fcf95674648310a3efb0d78529a37EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l+q0mENpq02s5ShPq0fuGQ");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*USJqSPKM_kWGN4dh8hHAqA");
internal static readonly GlobalObjectKey IdCostcenterSAP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cRyjvjb5qUy_xujuO6btGQ");

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

private long _ssRequisitionId;
public long ssRequisitionId{
  get{
      return _ssRequisitionId;
  }
  set{
      if((_ssRequisitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRequisitionId = value;
      }
  }
}

private long _ssCostcenterSAP;
public long ssCostcenterSAP{
  get{
      return _ssCostcenterSAP;
  }
  set{
      if((_ssCostcenterSAP!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCostcenterSAP = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_114fcf95674648310a3efb0d78529a37EntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssRequisitionId = 0L;
_ssCostcenterSAP = 0L;
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
ssId = r.ReadLongInteger(index++, "RequisitionCostCenter.Id", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionCostCenter.RequisitionId", 0L);
ssCostcenterSAP = r.ReadEntityReferenceLongInteger(index++, "RequisitionCostCenter.CostcenterSAP", 0L);
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
public void ReadIM(EN_114fcf95674648310a3efb0d78529a37EntityRecord r) {
this = r;
}


public static bool operator == (EN_114fcf95674648310a3efb0d78529a37EntityRecord a, EN_114fcf95674648310a3efb0d78529a37EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssCostcenterSAP != b.ssCostcenterSAP) return false;
return true;
}

public static bool operator != (EN_114fcf95674648310a3efb0d78529a37EntityRecord a, EN_114fcf95674648310a3efb0d78529a37EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_114fcf95674648310a3efb0d78529a37EntityRecord)) return false;
return (this == (EN_114fcf95674648310a3efb0d78529a37EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssCostcenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_114fcf95674648310a3efb0d78529a37EntityRecord Duplicate() {
EN_114fcf95674648310a3efb0d78529a37EntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssCostcenterSAP = this._ssCostcenterSAP;
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
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostcenterSAP")) variable.Value = ssCostcenterSAP; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRequisitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCostcenterSAP)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRequisitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCostcenterSAP)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdCostcenterSAP) {
return ssCostcenterSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdCostcenterSAP.Key.AsGuid) {
return ssCostcenterSAP;
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
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionId);
ssCostcenterSAP = (long) other.AttributeGet(IdCostcenterSAP);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCostcenterSAP);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCostcenterSAP);
}
} // EN_114fcf95674648310a3efb0d78529a37EntityRecord

/// <summary>
/// RecordList type <code>RequisitionCostCenterList</code> that represents a record list of
///  <code>RequisitionCostCenter</code>
/// </summary>
public partial class RL_943f36694cec370c0ce0c406bfa23715 : GenericRecordList<EN_114fcf95674648310a3efb0d78529a37EntityRecord>, IEnumerable, IEnumerator {

protected override EN_114fcf95674648310a3efb0d78529a37EntityRecord GetElementDefaultValue() {
return new EN_114fcf95674648310a3efb0d78529a37EntityRecord();
}

public T[] ToArray<T>(Func<EN_114fcf95674648310a3efb0d78529a37EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_943f36694cec370c0ce0c406bfa23715 recordList, Func<EN_114fcf95674648310a3efb0d78529a37EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_943f36694cec370c0ce0c406bfa23715(EN_114fcf95674648310a3efb0d78529a37EntityRecord[] array) {
  RL_943f36694cec370c0ce0c406bfa23715 result = new RL_943f36694cec370c0ce0c406bfa23715();
result.InnerFromArray(array);
    return result;
}

public static RL_943f36694cec370c0ce0c406bfa23715 ToList<T>(T[] array, Func <T, EN_114fcf95674648310a3efb0d78529a37EntityRecord> converter) {
  RL_943f36694cec370c0ce0c406bfa23715 result = new RL_943f36694cec370c0ce0c406bfa23715();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_943f36694cec370c0ce0c406bfa23715 FromRestList<T>(RestList<T> restList, Func <T, EN_114fcf95674648310a3efb0d78529a37EntityRecord> converter) {
  RL_943f36694cec370c0ce0c406bfa23715 result = new RL_943f36694cec370c0ce0c406bfa23715();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_943f36694cec370c0ce0c406bfa23715() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_114fcf95674648310a3efb0d78529a37EntityRecord> NewList() {
return new RL_943f36694cec370c0ce0c406bfa23715();
}


} // RL_943f36694cec370c0ce0c406bfa23715
}
