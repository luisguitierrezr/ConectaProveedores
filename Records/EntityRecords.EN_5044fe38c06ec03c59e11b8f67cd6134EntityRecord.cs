using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Bank (K6Kj2891k0O0Iub4YfCd5Q)
///  <code>EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord</code> that represents <code>Bank</code
/// > <p>Description: Entity to hold the list of banks.</p>
/// </summary>
// Name: Bank
public partial struct EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord : ITypedRecord<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*oE2mqRugpkWjw_sOmI847A");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*xk+ESexeTkO2rAQeXi2EtA");
internal static readonly GlobalObjectKey IdShortName = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*X2jrhwt+A0uwdxennfbx3w");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*QR4BVA_NDUK9ZWSOkjkb3A");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*AQYsLJ1oeEGPAUewcpirmw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*AWwhxY_7BECTehDrIIDiMA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(6,true);
          _ssId = value;
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

private string _ssShortName;
public string ssShortName{
  get{
      return _ssShortName;
  }
  set{
      if((_ssShortName!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssShortName = value;
      }
  }
}

private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCode = value;
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

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssOrder = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssName = "";
_ssShortName = "";
_ssCode = "";
_ssIsActive = true;
_ssOrder = 0;
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
ssId = r.ReadLongInteger(index++, "Bank.Id", 0L);
ssName = r.ReadText(index++, "Bank.Name", "");
ssShortName = r.ReadText(index++, "Bank.ShortName", "");
ssCode = r.ReadText(index++, "Bank.Code", "");
ssIsActive = r.ReadBoolean(index++, "Bank.IsActive", true);
ssOrder = r.ReadInteger(index++, "Bank.Order", 0);
ChangedAttributes = new BitArray(6,false);
OptimizedAttributes = new BitArray(6,false);
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
public void ReadIM(EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord r) {
this = r;
}


public static bool operator == (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord a, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssShortName != b.ssShortName) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord a, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord)) return false;
return (this == (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssShortName.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord Duplicate() {
EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssShortName = this._ssShortName;
t._ssCode = this._ssCode;
t._ssIsActive = this._ssIsActive;
t._ssOrder = this._ssOrder;
t.ChangedAttributes = new BitArray(6);
t.OptimizedAttributes = new BitArray(6);
for(int i = 0; i < 6; i++){
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "shortname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortName")) variable.Value = ssShortName; else variable.Optimized = true;
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdShortName)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCode)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[4];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[5];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdShortName)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCode)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[5];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdShortName) {
return ssShortName;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdShortName.Key.AsGuid) {
return ssShortName;
}
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssShortName = (string) other.AttributeGet(IdShortName);
ChangedAttributes[2] = other.ChangedAttributeGet(IdShortName);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdShortName);
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCode);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsActive);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[5] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord

/// <summary>
/// RecordList type <code>BankList</code> that represents a record list of <code>Bank</code>
/// </summary>
public partial class RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 : GenericRecordList<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord GetElementDefaultValue() {
return new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
}

public T[] ToArray<T>(Func<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 recordList, Func<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8(EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord[] array) {
  RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 result = new RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8();
result.InnerFromArray(array);
    return result;
}

public static RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 ToList<T>(T[] array, Func <T, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> converter) {
  RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 result = new RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 FromRestList<T>(RestList<T> restList, Func <T, EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> converter) {
  RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8 result = new RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord> NewList() {
return new RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8();
}


} // RL_9c90bb3fc154b3e0ebbcdca6c89a1ff8
}
