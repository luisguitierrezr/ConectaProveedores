using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedSelloDigital (gQwu73tQEE2ahCkNh0wWGQ)
///  <code>EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord</code> that represent
/// s <code>InvoiceExtendedSelloDigital</code> <p>Description: Entity that holds Invoice Extended Sello
///  Digital.</p>
/// </summary>
// Name: InvoiceExtendedSelloDigital
public partial struct EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord : ITypedRecord<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> {
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+AfZ72FwTkS5l_04ybOdlw");
internal static readonly GlobalObjectKey IdSelloDigital = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1atyTF6eQ0CToXQEvXBEOg");

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssInvoiceId = value;
      }
  }
}

private byte[] _ssSelloDigital;
public byte[] ssSelloDigital{
  get{
      return _ssSelloDigital;
  }
  set{
      if((_ssSelloDigital!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSelloDigital = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssInvoiceId = 0L;
_ssSelloDigital = new byte[] {};
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
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedSelloDigital.InvoiceId", 0L);
ssSelloDigital = r.ReadBinaryData(index++, "InvoiceExtendedSelloDigital.SelloDigital", new byte[] {});
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord r) {
this = r;
}


public static bool operator == (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord a, EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord b) {
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssSelloDigital, b.ssSelloDigital)) return false;
return true;
}

public static bool operator != (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord a, EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord)) return false;
return (this == (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssSelloDigital.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord Duplicate() {
EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord t;
t._ssInvoiceId = this._ssInvoiceId;
t._ssSelloDigital = this._ssSelloDigital;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
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
if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "sellodigital") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SelloDigital")) variable.Value = ssSelloDigital; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSelloDigital)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSelloDigital)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdSelloDigital) {
return ssSelloDigital;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdSelloDigital.Key.AsGuid) {
return ssSelloDigital;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdInvoiceId);
ssSelloDigital = (byte[]) other.AttributeGet(IdSelloDigital);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSelloDigital);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSelloDigital);
}
} // EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedSelloDigitalList</code> that represents a record list of
///  <code>InvoiceExtendedSelloDigital</code>
/// </summary>
public partial class RL_0eaee3d7802d373565fb609ec0956574 : GenericRecordList<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord GetElementDefaultValue() {
return new EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord();
}

public T[] ToArray<T>(Func<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0eaee3d7802d373565fb609ec0956574 recordList, Func<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0eaee3d7802d373565fb609ec0956574(EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord[] array) {
  RL_0eaee3d7802d373565fb609ec0956574 result = new RL_0eaee3d7802d373565fb609ec0956574();
result.InnerFromArray(array);
    return result;
}

public static RL_0eaee3d7802d373565fb609ec0956574 ToList<T>(T[] array, Func <T, EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> converter) {
  RL_0eaee3d7802d373565fb609ec0956574 result = new RL_0eaee3d7802d373565fb609ec0956574();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0eaee3d7802d373565fb609ec0956574 FromRestList<T>(RestList<T> restList, Func <T, EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> converter) {
  RL_0eaee3d7802d373565fb609ec0956574 result = new RL_0eaee3d7802d373565fb609ec0956574();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0eaee3d7802d373565fb609ec0956574() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord> NewList() {
return new RL_0eaee3d7802d373565fb609ec0956574();
}


} // RL_0eaee3d7802d373565fb609ec0956574
}
