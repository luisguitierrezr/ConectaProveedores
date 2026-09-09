using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ApprovalStatus (E9qXYTkzVUm79Wm89wrrsw)
///  <code>EN_e97ac0d21205ff90ab42100bba6097baEntityRecord</code> that represent
/// s <code>ApprovalStatus</code> <p>Description: Entity that holds the Approval Status.</p>
/// </summary>
// Name: ApprovalStatus
public partial struct EN_e97ac0d21205ff90ab42100bba6097baEntityRecord : ITypedRecord<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q4wm8U86LkGLuFyRxYLKdQ");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nBoPoS7UkE6LMjvBS5bMFQ");
internal static readonly GlobalObjectKey IdClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wgYwD4TLPEOLJCC4t79o8w");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ru+XIYIL80uly6YnRG335g");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QNCtv3h_vkK5px1ExF0nJw");
internal static readonly GlobalObjectKey IdIsCyA = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xUwOyIAihk2JjaEXSMZhvA");
internal static readonly GlobalObjectKey IdIsCyAApproval = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8hRe7mBA90qjShkTVsQGkQ");
internal static readonly GlobalObjectKey IdIsReq = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*L094Jo4XJEOHAtwZc0yOrw");
internal static readonly GlobalObjectKey IdIsInv = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l7bX3tzLLUGfHaQGEGdBKg");
internal static readonly GlobalObjectKey IdLabelES = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*F5_OWKTs8E+k2UUZpS5URQ");

private int _ssId;
public int ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
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

private bool _ssIsCyA;
public bool ssIsCyA{
  get{
      return _ssIsCyA;
  }
  set{
      if((_ssIsCyA!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsCyA = value;
      }
  }
}

private bool _ssIsCyAApproval;
public bool ssIsCyAApproval{
  get{
      return _ssIsCyAApproval;
  }
  set{
      if((_ssIsCyAApproval!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsCyAApproval = value;
      }
  }
}

private bool _ssIsReq;
public bool ssIsReq{
  get{
      return _ssIsReq;
  }
  set{
      if((_ssIsReq!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsReq = value;
      }
  }
}

private bool _ssIsInv;
public bool ssIsInv{
  get{
      return _ssIsInv;
  }
  set{
      if((_ssIsInv!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsInv = value;
      }
  }
}

private string _ssLabelES;
public string ssLabelES{
  get{
      return _ssLabelES;
  }
  set{
      if((_ssLabelES!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssLabelES = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0;
_ssLabel = "";
_ssClass = "";
_ssOrder = 0;
_ssIs_Active = false;
_ssIsCyA = false;
_ssIsCyAApproval = false;
_ssIsReq = false;
_ssIsInv = false;
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
ssId = r.ReadInteger(index++, "ApprovalStatus.Id", 0);
ssLabel = r.ReadText(index++, "ApprovalStatus.Label", "");
ssClass = r.ReadText(index++, "ApprovalStatus.Class", "");
ssOrder = r.ReadInteger(index++, "ApprovalStatus.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "ApprovalStatus.Is_Active", false);
ssIsCyA = r.ReadBoolean(index++, "ApprovalStatus.IsCyA", false);
ssIsCyAApproval = r.ReadBoolean(index++, "ApprovalStatus.IsCyAApproval", false);
ssIsReq = r.ReadBoolean(index++, "ApprovalStatus.IsReq", false);
ssIsInv = r.ReadBoolean(index++, "ApprovalStatus.IsInv", false);
ssLabelES = r.ReadText(index++, "ApprovalStatus.LabelES", "");
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_e97ac0d21205ff90ab42100bba6097baEntityRecord r) {
this = r;
}


public static bool operator == (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord a, EN_e97ac0d21205ff90ab42100bba6097baEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssClass != b.ssClass) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
if (a.ssIsCyA != b.ssIsCyA) return false;
if (a.ssIsCyAApproval != b.ssIsCyAApproval) return false;
if (a.ssIsReq != b.ssIsReq) return false;
if (a.ssIsInv != b.ssIsInv) return false;
if (a.ssLabelES != b.ssLabelES) return false;
return true;
}

public static bool operator != (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord a, EN_e97ac0d21205ff90ab42100bba6097baEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)) return false;
return (this == (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssClass.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
 ^ ssIsCyA.GetHashCode()
 ^ ssIsCyAApproval.GetHashCode()
 ^ ssIsReq.GetHashCode()
 ^ ssIsInv.GetHashCode()
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


public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord Duplicate() {
EN_e97ac0d21205ff90ab42100bba6097baEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssClass = this._ssClass;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t._ssIsCyA = this._ssIsCyA;
t._ssIsCyAApproval = this._ssIsCyAApproval;
t._ssIsReq = this._ssIsReq;
t._ssIsInv = this._ssIsInv;
t._ssLabelES = this._ssLabelES;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
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
} else if (head == "iscya") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCyA")) variable.Value = ssIsCyA; else variable.Optimized = true;
} else if (head == "iscyaapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCyAApproval")) variable.Value = ssIsCyAApproval; else variable.Optimized = true;
} else if (head == "isreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReq")) variable.Value = ssIsReq; else variable.Optimized = true;
} else if (head == "isinv") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsInv")) variable.Value = ssIsInv; else variable.Optimized = true;
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
if (key.Equals(IdIsCyA)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsCyAApproval)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsReq)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIsInv)) {
return ChangedAttributes[8];
}
if (key.Equals(IdLabelES)) {
return ChangedAttributes[9];
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
if (key.Equals(IdIsCyA)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsCyAApproval)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsReq)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIsInv)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdLabelES)) {
return OptimizedAttributes[9];
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
if (key == IdIsCyA) {
return ssIsCyA;
}
if (key == IdIsCyAApproval) {
return ssIsCyAApproval;
}
if (key == IdIsReq) {
return ssIsReq;
}
if (key == IdIsInv) {
return ssIsInv;
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
if (attributeKey == IdIsCyA.Key.AsGuid) {
return ssIsCyA;
}
if (attributeKey == IdIsCyAApproval.Key.AsGuid) {
return ssIsCyAApproval;
}
if (attributeKey == IdIsReq.Key.AsGuid) {
return ssIsReq;
}
if (attributeKey == IdIsInv.Key.AsGuid) {
return ssIsInv;
}
if (attributeKey == IdLabelES.Key.AsGuid) {
return ssLabelES;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
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
ssIsCyA = (bool) other.AttributeGet(IdIsCyA);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsCyA);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsCyA);
ssIsCyAApproval = (bool) other.AttributeGet(IdIsCyAApproval);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsCyAApproval);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsCyAApproval);
ssIsReq = (bool) other.AttributeGet(IdIsReq);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsReq);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsReq);
ssIsInv = (bool) other.AttributeGet(IdIsInv);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsInv);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsInv);
ssLabelES = (string) other.AttributeGet(IdLabelES);
ChangedAttributes[9] = other.ChangedAttributeGet(IdLabelES);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdLabelES);
}
} // EN_e97ac0d21205ff90ab42100bba6097baEntityRecord

/// <summary>
/// RecordList type <code>ApprovalStatusList</code> that represents a record list of
///  <code>ApprovalStatus</code>
/// </summary>
public partial class RL_e5c244beec12a988fdf56d4ade2c01e6 : GenericRecordList<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord>, IEnumerable, IEnumerator {

protected override EN_e97ac0d21205ff90ab42100bba6097baEntityRecord GetElementDefaultValue() {
return new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
}

public T[] ToArray<T>(Func<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e5c244beec12a988fdf56d4ade2c01e6 recordList, Func<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e5c244beec12a988fdf56d4ade2c01e6(EN_e97ac0d21205ff90ab42100bba6097baEntityRecord[] array) {
  RL_e5c244beec12a988fdf56d4ade2c01e6 result = new RL_e5c244beec12a988fdf56d4ade2c01e6();
result.InnerFromArray(array);
    return result;
}

public static RL_e5c244beec12a988fdf56d4ade2c01e6 ToList<T>(T[] array, Func <T, EN_e97ac0d21205ff90ab42100bba6097baEntityRecord> converter) {
  RL_e5c244beec12a988fdf56d4ade2c01e6 result = new RL_e5c244beec12a988fdf56d4ade2c01e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e5c244beec12a988fdf56d4ade2c01e6 FromRestList<T>(RestList<T> restList, Func <T, EN_e97ac0d21205ff90ab42100bba6097baEntityRecord> converter) {
  RL_e5c244beec12a988fdf56d4ade2c01e6 result = new RL_e5c244beec12a988fdf56d4ade2c01e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e5c244beec12a988fdf56d4ade2c01e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord> NewList() {
return new RL_e5c244beec12a988fdf56d4ade2c01e6();
}


} // RL_e5c244beec12a988fdf56d4ade2c01e6
}
