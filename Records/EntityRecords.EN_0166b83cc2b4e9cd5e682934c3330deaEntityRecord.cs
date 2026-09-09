using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioStatus (o5hCD3UOP0KdTBLIfkjodg)
///  <code>EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord</code> that represent
/// s <code>FolioStatus</code> <p>Description: </p>
/// </summary>
// Name: FolioStatus
public partial struct EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord : ITypedRecord<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DdEuWF9uzEmFQNS2p5Mpmg");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KfK_o7GjyEiUjCDxHgTj0g");
internal static readonly GlobalObjectKey IdClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*he5lmDnS+U+a8UKncZxYCw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*g+P1rMwfVUmTxbEKYWNhLg");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fDfrRBLY5kee9r4qie2BHw");
internal static readonly GlobalObjectKey IdLabelES = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MTB5_rfXSkeJfw7+Yo3+FQ");

private int _ssId;
public int ssId{
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

private string _ssClass;
public string ssClass{
  get{
      return _ssClass;
  }
  set{
      if((_ssClass!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssClass = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssIs_Active!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIs_Active = value;
      }
  }
}

private string _ssLabelES;
public string ssLabelES{
  get{
      return _ssLabelES;
  }
  set{
      if((_ssLabelES!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssLabelES = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0;
_ssLabel = "";
_ssClass = "";
_ssOrder = 0;
_ssIs_Active = false;
_ssLabelES = "";
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
ssId = r.ReadInteger(index++, "FolioStatus.Id", 0);
ssLabel = r.ReadText(index++, "FolioStatus.Label", "");
ssClass = r.ReadText(index++, "FolioStatus.Class", "");
ssOrder = r.ReadInteger(index++, "FolioStatus.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "FolioStatus.Is_Active", false);
ssLabelES = r.ReadText(index++, "FolioStatus.LabelES", "");
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
public void ReadIM(EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord r) {
this = r;
}


public static bool operator == (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord a, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssClass != b.ssClass) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
if (a.ssLabelES != b.ssLabelES) return false;
return true;
}

public static bool operator != (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord a, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)) return false;
return (this == (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssClass.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
 ^ ssLabelES.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord Duplicate() {
EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssClass = this._ssClass;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t._ssLabelES = this._ssLabelES;
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
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "class") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Class")) variable.Value = ssClass; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
} else if (head == "labeles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LabelES")) variable.Value = ssLabelES; else variable.Optimized = true;
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
if (key.Equals(IdClass)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[4];
}
if (key.Equals(IdLabelES)) {
return ChangedAttributes[5];
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
if (key.Equals(IdClass)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdLabelES)) {
return OptimizedAttributes[5];
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
if (key == IdClass) {
return ssClass;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdIs_Active) {
return ssIs_Active;
}
if (key == IdLabelES) {
return ssLabelES;
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
if (attributeKey == IdClass.Key.AsGuid) {
return ssClass;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdIs_Active.Key.AsGuid) {
return ssIs_Active;
}
if (attributeKey == IdLabelES.Key.AsGuid) {
return ssLabelES;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssClass = (string) other.AttributeGet(IdClass);
ChangedAttributes[2] = other.ChangedAttributeGet(IdClass);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdClass);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIs_Active);
ssLabelES = (string) other.AttributeGet(IdLabelES);
ChangedAttributes[5] = other.ChangedAttributeGet(IdLabelES);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdLabelES);
}
} // EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord

/// <summary>
/// RecordList type <code>FolioStatusList</code> that represents a record list of
///  <code>FolioStatus</code>
/// </summary>
public partial class RL_cd4c2984de2dd78f927e3af645c73ad6 : GenericRecordList<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord>, IEnumerable, IEnumerator {

protected override EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord GetElementDefaultValue() {
return new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
}

public T[] ToArray<T>(Func<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cd4c2984de2dd78f927e3af645c73ad6 recordList, Func<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cd4c2984de2dd78f927e3af645c73ad6(EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord[] array) {
  RL_cd4c2984de2dd78f927e3af645c73ad6 result = new RL_cd4c2984de2dd78f927e3af645c73ad6();
result.InnerFromArray(array);
    return result;
}

public static RL_cd4c2984de2dd78f927e3af645c73ad6 ToList<T>(T[] array, Func <T, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> converter) {
  RL_cd4c2984de2dd78f927e3af645c73ad6 result = new RL_cd4c2984de2dd78f927e3af645c73ad6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cd4c2984de2dd78f927e3af645c73ad6 FromRestList<T>(RestList<T> restList, Func <T, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> converter) {
  RL_cd4c2984de2dd78f927e3af645c73ad6 result = new RL_cd4c2984de2dd78f927e3af645c73ad6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cd4c2984de2dd78f927e3af645c73ad6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> NewList() {
return new RL_cd4c2984de2dd78f927e3af645c73ad6();
}


} // RL_cd4c2984de2dd78f927e3af645c73ad6
}
