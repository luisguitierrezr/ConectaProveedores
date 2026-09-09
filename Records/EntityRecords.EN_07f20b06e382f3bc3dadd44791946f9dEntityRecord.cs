using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderCostCenter (a8XiVrhX3kyQI_VT9wVKag)
///  <code>EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord</code> that represent
/// s <code>OrderCostCenter</code> <p>Description: Order Cost Center</p>
/// </summary>
// Name: OrderCostCenter
public partial struct EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord : ITypedRecord<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*37fWsraN3U2ZvrhoL0tOmw");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Nb2Hw4m7P0azJj0RqVEqQg");
internal static readonly GlobalObjectKey IdCostcenterSAP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0RGZkjGTx0+Gcv6ywZ5NkQ");

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

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderId = value;
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

public EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssOrderId = 0L;
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
ssId = r.ReadLongInteger(index++, "OrderCostCenter.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderCostCenter.OrderId", 0L);
ssCostcenterSAP = r.ReadEntityReferenceLongInteger(index++, "OrderCostCenter.CostcenterSAP", 0L);
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
public void ReadIM(EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord r) {
this = r;
}


public static bool operator == (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord a, EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssCostcenterSAP != b.ssCostcenterSAP) return false;
return true;
}

public static bool operator != (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord a, EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord)) return false;
return (this == (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
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


public EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord Duplicate() {
EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
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
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostcenterSAP")) variable.Value = ssCostcenterSAP; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderId)) {
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
if (key.Equals(IdOrderId)) {
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
if (key == IdOrderId) {
return ssOrderId;
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
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
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
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
ssCostcenterSAP = (long) other.AttributeGet(IdCostcenterSAP);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCostcenterSAP);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCostcenterSAP);
}
} // EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord

/// <summary>
/// RecordList type <code>OrderCostCenterList</code> that represents a record list of
///  <code>OrderCostCenter</code>
/// </summary>
public partial class RL_940862551663238e19e204152cf393a9 : GenericRecordList<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord GetElementDefaultValue() {
return new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord();
}

public T[] ToArray<T>(Func<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_940862551663238e19e204152cf393a9 recordList, Func<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_940862551663238e19e204152cf393a9(EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord[] array) {
  RL_940862551663238e19e204152cf393a9 result = new RL_940862551663238e19e204152cf393a9();
result.InnerFromArray(array);
    return result;
}

public static RL_940862551663238e19e204152cf393a9 ToList<T>(T[] array, Func <T, EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord> converter) {
  RL_940862551663238e19e204152cf393a9 result = new RL_940862551663238e19e204152cf393a9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_940862551663238e19e204152cf393a9 FromRestList<T>(RestList<T> restList, Func <T, EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord> converter) {
  RL_940862551663238e19e204152cf393a9 result = new RL_940862551663238e19e204152cf393a9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_940862551663238e19e204152cf393a9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord> NewList() {
return new RL_940862551663238e19e204152cf393a9();
}


} // RL_940862551663238e19e204152cf393a9
}
