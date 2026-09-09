using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionStatus (x39Coww5aEW0Jm+V0_a79w)
///  <code>EN_0554a1252840ba4a5c4e6af5899608adEntityRecord</code> that represent
/// s <code>RequisitionStatus</code> <p>Description: Entity that holds Requisition Status.</p>
/// </summary>
// Name: RequisitionStatus
public partial struct EN_0554a1252840ba4a5c4e6af5899608adEntityRecord : ITypedRecord<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qKm7EkQyH0KQ5Jl2YXUsQw");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7Z0YZS5zz0S5OU+uqwN6xQ");
internal static readonly GlobalObjectKey IdClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EG_VVBBSiUuD5JSbrWa2Cg");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c5S7a0gN7E6dgPZlMrNFIw");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*162cxB84206ZYPNfVztTpw");
internal static readonly GlobalObjectKey IdLabelES = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GNwwruLTLkCUJxZGxGkrIg");

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

public EN_0554a1252840ba4a5c4e6af5899608adEntityRecord() {
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
ssId = r.ReadInteger(index++, "RequisitionStatus.Id", 0);
ssLabel = r.ReadText(index++, "RequisitionStatus.Label", "");
ssClass = r.ReadText(index++, "RequisitionStatus.Class", "");
ssOrder = r.ReadInteger(index++, "RequisitionStatus.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "RequisitionStatus.Is_Active", false);
ssLabelES = r.ReadText(index++, "RequisitionStatus.LabelES", "");
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
public void ReadIM(EN_0554a1252840ba4a5c4e6af5899608adEntityRecord r) {
this = r;
}


public static bool operator == (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord a, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssClass != b.ssClass) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
if (a.ssLabelES != b.ssLabelES) return false;
return true;
}

public static bool operator != (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord a, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord)) return false;
return (this == (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord)o);
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


public EN_0554a1252840ba4a5c4e6af5899608adEntityRecord Duplicate() {
EN_0554a1252840ba4a5c4e6af5899608adEntityRecord t;
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
} // EN_0554a1252840ba4a5c4e6af5899608adEntityRecord

/// <summary>
/// RecordList type <code>RequisitionStatusList</code> that represents a record list of
///  <code>RequisitionStatus</code>
/// </summary>
public partial class RL_7320d4cc71cc8548f7397af55e3d41fc : GenericRecordList<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord>, IEnumerable, IEnumerator {

protected override EN_0554a1252840ba4a5c4e6af5899608adEntityRecord GetElementDefaultValue() {
return new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
}

public T[] ToArray<T>(Func<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7320d4cc71cc8548f7397af55e3d41fc recordList, Func<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7320d4cc71cc8548f7397af55e3d41fc(EN_0554a1252840ba4a5c4e6af5899608adEntityRecord[] array) {
  RL_7320d4cc71cc8548f7397af55e3d41fc result = new RL_7320d4cc71cc8548f7397af55e3d41fc();
result.InnerFromArray(array);
    return result;
}

public static RL_7320d4cc71cc8548f7397af55e3d41fc ToList<T>(T[] array, Func <T, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord> converter) {
  RL_7320d4cc71cc8548f7397af55e3d41fc result = new RL_7320d4cc71cc8548f7397af55e3d41fc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7320d4cc71cc8548f7397af55e3d41fc FromRestList<T>(RestList<T> restList, Func <T, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord> converter) {
  RL_7320d4cc71cc8548f7397af55e3d41fc result = new RL_7320d4cc71cc8548f7397af55e3d41fc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7320d4cc71cc8548f7397af55e3d41fc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord> NewList() {
return new RL_7320d4cc71cc8548f7397af55e3d41fc();
}


} // RL_7320d4cc71cc8548f7397af55e3d41fc
}
