using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Currency (LgkbBB+MbE6j+jdNBNUO3A)
///  <code>EN_327b52812b8badb247bde4975c10d441EntityRecord</code> that represents <code>Currency</code
/// > <p>Description: Entity to hold the currencies.</p>
/// </summary>
// Name: Currency
public partial struct EN_327b52812b8badb247bde4975c10d441EntityRecord : ITypedRecord<EN_327b52812b8badb247bde4975c10d441EntityRecord> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*wotUNsNVcUqnXLXi+N19Tw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*jEmT0LjOuEmB7QtZ3WSsLA");
internal static readonly GlobalObjectKey IdSymbol = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*MK6k7rNazEezYQf4tdgMpA");
internal static readonly GlobalObjectKey IdMinorUnitDecimals = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*P0wwBjpp4Em4lhssBVSlrw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*SAYnveeZIUKOncBNVPumtw");

private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssCode = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private string _ssSymbol;
public string ssSymbol{
  get{
      return _ssSymbol;
  }
  set{
      if((_ssSymbol!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssSymbol = value;
      }
  }
}

private int _ssMinorUnitDecimals;
public int ssMinorUnitDecimals{
  get{
      return _ssMinorUnitDecimals;
  }
  set{
      if((_ssMinorUnitDecimals!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssMinorUnitDecimals = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsActive = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_327b52812b8badb247bde4975c10d441EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssCode = "";
_ssName = "";
_ssSymbol = "";
_ssMinorUnitDecimals = 0;
_ssIsActive = false;
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
ssCode = r.ReadText(index++, "Currency.Code", "");
ssName = r.ReadText(index++, "Currency.Name", "");
ssSymbol = r.ReadText(index++, "Currency.Symbol", "");
ssMinorUnitDecimals = r.ReadInteger(index++, "Currency.MinorUnitDecimals", 0);
ssIsActive = r.ReadBoolean(index++, "Currency.IsActive", false);
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_327b52812b8badb247bde4975c10d441EntityRecord r) {
this = r;
}


public static bool operator == (EN_327b52812b8badb247bde4975c10d441EntityRecord a, EN_327b52812b8badb247bde4975c10d441EntityRecord b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssName != b.ssName) return false;
if (a.ssSymbol != b.ssSymbol) return false;
if (a.ssMinorUnitDecimals != b.ssMinorUnitDecimals) return false;
if (a.ssIsActive != b.ssIsActive) return false;
return true;
}

public static bool operator != (EN_327b52812b8badb247bde4975c10d441EntityRecord a, EN_327b52812b8badb247bde4975c10d441EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_327b52812b8badb247bde4975c10d441EntityRecord)) return false;
return (this == (EN_327b52812b8badb247bde4975c10d441EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssSymbol.GetHashCode()
 ^ ssMinorUnitDecimals.GetHashCode()
 ^ ssIsActive.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_327b52812b8badb247bde4975c10d441EntityRecord Duplicate() {
EN_327b52812b8badb247bde4975c10d441EntityRecord t;
t._ssCode = this._ssCode;
t._ssName = this._ssName;
t._ssSymbol = this._ssSymbol;
t._ssMinorUnitDecimals = this._ssMinorUnitDecimals;
t._ssIsActive = this._ssIsActive;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "symbol") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Symbol")) variable.Value = ssSymbol; else variable.Optimized = true;
} else if (head == "minorunitdecimals") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinorUnitDecimals")) variable.Value = ssMinorUnitDecimals; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdCode)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdSymbol)) {
return ChangedAttributes[2];
}
if (key.Equals(IdMinorUnitDecimals)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdCode)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdSymbol)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdMinorUnitDecimals)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCode) {
return ssCode;
}
if (key == IdName) {
return ssName;
}
if (key == IdSymbol) {
return ssSymbol;
}
if (key == IdMinorUnitDecimals) {
return ssMinorUnitDecimals;
}
if (key == IdIsActive) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdSymbol.Key.AsGuid) {
return ssSymbol;
}
if (attributeKey == IdMinorUnitDecimals.Key.AsGuid) {
return ssMinorUnitDecimals;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[0] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdCode);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssSymbol = (string) other.AttributeGet(IdSymbol);
ChangedAttributes[2] = other.ChangedAttributeGet(IdSymbol);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdSymbol);
ssMinorUnitDecimals = (int) other.AttributeGet(IdMinorUnitDecimals);
ChangedAttributes[3] = other.ChangedAttributeGet(IdMinorUnitDecimals);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMinorUnitDecimals);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsActive);
}
} // EN_327b52812b8badb247bde4975c10d441EntityRecord

/// <summary>
/// RecordList type <code>CurrencyList</code> that represents a record list of <code>Currency</code>
/// </summary>
public partial class RL_92df47e5c521e3415cf3c50600a7ec4a : GenericRecordList<EN_327b52812b8badb247bde4975c10d441EntityRecord>, IEnumerable, IEnumerator {

protected override EN_327b52812b8badb247bde4975c10d441EntityRecord GetElementDefaultValue() {
return new EN_327b52812b8badb247bde4975c10d441EntityRecord();
}

public T[] ToArray<T>(Func<EN_327b52812b8badb247bde4975c10d441EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_92df47e5c521e3415cf3c50600a7ec4a recordList, Func<EN_327b52812b8badb247bde4975c10d441EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_92df47e5c521e3415cf3c50600a7ec4a(EN_327b52812b8badb247bde4975c10d441EntityRecord[] array) {
  RL_92df47e5c521e3415cf3c50600a7ec4a result = new RL_92df47e5c521e3415cf3c50600a7ec4a();
result.InnerFromArray(array);
    return result;
}

public static RL_92df47e5c521e3415cf3c50600a7ec4a ToList<T>(T[] array, Func <T, EN_327b52812b8badb247bde4975c10d441EntityRecord> converter) {
  RL_92df47e5c521e3415cf3c50600a7ec4a result = new RL_92df47e5c521e3415cf3c50600a7ec4a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_92df47e5c521e3415cf3c50600a7ec4a FromRestList<T>(RestList<T> restList, Func <T, EN_327b52812b8badb247bde4975c10d441EntityRecord> converter) {
  RL_92df47e5c521e3415cf3c50600a7ec4a result = new RL_92df47e5c521e3415cf3c50600a7ec4a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_92df47e5c521e3415cf3c50600a7ec4a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_327b52812b8badb247bde4975c10d441EntityRecord> NewList() {
return new RL_92df47e5c521e3415cf3c50600a7ec4a();
}


} // RL_92df47e5c521e3415cf3c50600a7ec4a
}
