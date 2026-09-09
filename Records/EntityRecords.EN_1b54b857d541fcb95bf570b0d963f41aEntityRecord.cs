using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ContractStatus (HkG7awH2mUGUSgJROceJlw)
///  <code>EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord</code> that represent
/// s <code>ContractStatus</code> <p>Description: Contract Status</p>
/// </summary>
// Name: ContractStatus
public partial struct EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord : ITypedRecord<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qg9ui0d5KE2GouygDHeeFA");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*f1qqakWVC06gHMNzafqQfw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DXNle7eRiEKMR+fjm+1dzw");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NQZMVQ56HEmTet24qoZ_8A");
internal static readonly GlobalObjectKey IdClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JOL0CnKuckKfKsoVDmyyfw");

private int _ssId;
public int ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssLabel = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrder = value;
      }
  }
}

private bool _ssIs_Active;
public bool ssIs_Active{
  get{
      return _ssIs_Active;
  }
  set{
      if((_ssIs_Active!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIs_Active = value;
      }
  }
}

private string _ssClass;
public string ssClass{
  get{
      return _ssClass;
  }
  set{
      if((_ssClass!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssClass = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0;
_ssLabel = "";
_ssOrder = 0;
_ssIs_Active = false;
_ssClass = "";
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
ssId = r.ReadInteger(index++, "ContractStatus.Id", 0);
ssLabel = r.ReadText(index++, "ContractStatus.Label", "");
ssOrder = r.ReadInteger(index++, "ContractStatus.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "ContractStatus.Is_Active", false);
ssClass = r.ReadText(index++, "ContractStatus.Class", "");
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
public void ReadIM(EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord r) {
this = r;
}


public static bool operator == (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord a, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
if (a.ssClass != b.ssClass) return false;
return true;
}

public static bool operator != (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord a, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord)) return false;
return (this == (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
 ^ ssClass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord Duplicate() {
EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t._ssClass = this._ssClass;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
} else if (head == "class") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Class")) variable.Value = ssClass; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[3];
}
if (key.Equals(IdClass)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdClass)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdIs_Active) {
return ssIs_Active;
}
if (key == IdClass) {
return ssClass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdIs_Active.Key.AsGuid) {
return ssIs_Active;
}
if (attributeKey == IdClass.Key.AsGuid) {
return ssClass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
ssClass = (string) other.AttributeGet(IdClass);
ChangedAttributes[4] = other.ChangedAttributeGet(IdClass);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdClass);
}
} // EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord

/// <summary>
/// RecordList type <code>ContractStatusList</code> that represents a record list of
///  <code>ContractStatus</code>
/// </summary>
public partial class RL_fbaa54ed5777cf8dde94c7a3d32ff6fe : GenericRecordList<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord GetElementDefaultValue() {
return new EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord();
}

public T[] ToArray<T>(Func<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fbaa54ed5777cf8dde94c7a3d32ff6fe recordList, Func<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fbaa54ed5777cf8dde94c7a3d32ff6fe(EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord[] array) {
  RL_fbaa54ed5777cf8dde94c7a3d32ff6fe result = new RL_fbaa54ed5777cf8dde94c7a3d32ff6fe();
result.InnerFromArray(array);
    return result;
}

public static RL_fbaa54ed5777cf8dde94c7a3d32ff6fe ToList<T>(T[] array, Func <T, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> converter) {
  RL_fbaa54ed5777cf8dde94c7a3d32ff6fe result = new RL_fbaa54ed5777cf8dde94c7a3d32ff6fe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fbaa54ed5777cf8dde94c7a3d32ff6fe FromRestList<T>(RestList<T> restList, Func <T, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> converter) {
  RL_fbaa54ed5777cf8dde94c7a3d32ff6fe result = new RL_fbaa54ed5777cf8dde94c7a3d32ff6fe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fbaa54ed5777cf8dde94c7a3d32ff6fe() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> NewList() {
return new RL_fbaa54ed5777cf8dde94c7a3d32ff6fe();
}


} // RL_fbaa54ed5777cf8dde94c7a3d32ff6fe
}
