using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedMoreCharges (Tb_21Gq2NEawj2YB4+Qbdw)
///  <code>EN_a9440c310249b67518f0615139b4c690EntityRecord</code> that represent
/// s <code>InvoiceExtendedMoreCharges</code> <p>Description: Entity that holds Invoice Extended More
///  Charges.</p>
/// </summary>
// Name: InvoiceExtendedMoreCharges
public partial struct EN_a9440c310249b67518f0615139b4c690EntityRecord : ITypedRecord<EN_a9440c310249b67518f0615139b4c690EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sEJQ_Pcq+k2+WiOt_sUCXQ");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rPNJT310mE6dPo3LQz1XFw");
internal static readonly GlobalObjectKey IdNombreConcepto = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WZjLHRqhv0CVzOka3LxZgw");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QCfiphmxvE2QJiKWvprq3Q");

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

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private string _ssNombreConcepto;
public string ssNombreConcepto{
  get{
      return _ssNombreConcepto;
  }
  set{
      if((_ssNombreConcepto!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssNombreConcepto = value;
      }
  }
}

private decimal _ssValue;
public decimal ssValue{
  get{
      return _ssValue;
  }
  set{
      if((_ssValue!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssValue = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_a9440c310249b67518f0615139b4c690EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssNombreConcepto = "";
_ssValue = 0.0M;
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
ssId = r.ReadLongInteger(index++, "InvoiceExtendedMoreCharges.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedMoreCharges.InvoiceId", 0L);
ssNombreConcepto = r.ReadText(index++, "InvoiceExtendedMoreCharges.NombreConcepto", "");
ssValue = r.ReadDecimal(index++, "InvoiceExtendedMoreCharges.Value", 0.0M);
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
public void ReadIM(EN_a9440c310249b67518f0615139b4c690EntityRecord r) {
this = r;
}


public static bool operator == (EN_a9440c310249b67518f0615139b4c690EntityRecord a, EN_a9440c310249b67518f0615139b4c690EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssNombreConcepto != b.ssNombreConcepto) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (EN_a9440c310249b67518f0615139b4c690EntityRecord a, EN_a9440c310249b67518f0615139b4c690EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_a9440c310249b67518f0615139b4c690EntityRecord)) return false;
return (this == (EN_a9440c310249b67518f0615139b4c690EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssNombreConcepto.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_a9440c310249b67518f0615139b4c690EntityRecord Duplicate() {
EN_a9440c310249b67518f0615139b4c690EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssNombreConcepto = this._ssNombreConcepto;
t._ssValue = this._ssValue;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "nombreconcepto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NombreConcepto")) variable.Value = ssNombreConcepto; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdNombreConcepto)) {
return ChangedAttributes[2];
}
if (key.Equals(IdValue)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdNombreConcepto)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdValue)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdNombreConcepto) {
return ssNombreConcepto;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdNombreConcepto.Key.AsGuid) {
return ssNombreConcepto;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
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
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssNombreConcepto = (string) other.AttributeGet(IdNombreConcepto);
ChangedAttributes[2] = other.ChangedAttributeGet(IdNombreConcepto);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdNombreConcepto);
ssValue = (decimal) other.AttributeGet(IdValue);
ChangedAttributes[3] = other.ChangedAttributeGet(IdValue);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdValue);
}
} // EN_a9440c310249b67518f0615139b4c690EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedMoreChargesList</code> that represents a record list of
///  <code>InvoiceExtendedMoreCharges</code>
/// </summary>
public partial class RL_4d4dc9b85c4a7d6bf03b676c2530ea4f : GenericRecordList<EN_a9440c310249b67518f0615139b4c690EntityRecord>, IEnumerable, IEnumerator {

protected override EN_a9440c310249b67518f0615139b4c690EntityRecord GetElementDefaultValue() {
return new EN_a9440c310249b67518f0615139b4c690EntityRecord();
}

public T[] ToArray<T>(Func<EN_a9440c310249b67518f0615139b4c690EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d4dc9b85c4a7d6bf03b676c2530ea4f recordList, Func<EN_a9440c310249b67518f0615139b4c690EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d4dc9b85c4a7d6bf03b676c2530ea4f(EN_a9440c310249b67518f0615139b4c690EntityRecord[] array) {
  RL_4d4dc9b85c4a7d6bf03b676c2530ea4f result = new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();
result.InnerFromArray(array);
    return result;
}

public static RL_4d4dc9b85c4a7d6bf03b676c2530ea4f ToList<T>(T[] array, Func <T, EN_a9440c310249b67518f0615139b4c690EntityRecord> converter) {
  RL_4d4dc9b85c4a7d6bf03b676c2530ea4f result = new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d4dc9b85c4a7d6bf03b676c2530ea4f FromRestList<T>(RestList<T> restList, Func <T, EN_a9440c310249b67518f0615139b4c690EntityRecord> converter) {
  RL_4d4dc9b85c4a7d6bf03b676c2530ea4f result = new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_a9440c310249b67518f0615139b4c690EntityRecord> NewList() {
return new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();
}


} // RL_4d4dc9b85c4a7d6bf03b676c2530ea4f
}
