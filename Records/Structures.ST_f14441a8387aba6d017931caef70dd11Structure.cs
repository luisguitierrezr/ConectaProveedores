namespace ssConectaProveedores {
/// <summary>
/// [Structure] StepUsers (3HoydZ3+ZUmFkUBXO88yYg)
///  <code>ST_f14441a8387aba6d017931caef70dd11Structure</code> that represents <code>StepUsers</code
/// > <p>Description: Step Structure.</p>
/// </summary>
// Name: StepUsers
public partial struct ST_f14441a8387aba6d017931caef70dd11Structure : ITypedRecord<ST_f14441a8387aba6d017931caef70dd11Structure> {
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c1H0R3H3xkilbB+_Z2BEkw");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tjR4B0qPbUGsBpCSIf1Paw");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*k5bJYZisiUG_Mx2ZcgYgEw");
internal static readonly GlobalObjectKey IdUnderLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_SbGtCpKMEeuzfy5c4A_ag");
internal static readonly GlobalObjectKey IdUnderLabelNChar = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8pDC2c9ewEyOAo1AZVmwRw");

public int ssOrder;

public string ssLabel;

public string ssExtendedClass;

public string ssUnderLabel;

public int ssUnderLabelNChar;


public BitArray OptimizedAttributes;

public ST_f14441a8387aba6d017931caef70dd11Structure() {
OptimizedAttributes = null;
ssOrder = 0;
ssLabel = "";
ssExtendedClass = "";
ssUnderLabel = "";
ssUnderLabelNChar = 0;
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
ssOrder = r.ReadInteger(index++, "StepUsers.Order", 0);
ssLabel = r.ReadText(index++, "StepUsers.Label", "");
ssExtendedClass = r.ReadText(index++, "StepUsers.ExtendedClass", "");
ssUnderLabel = r.ReadText(index++, "StepUsers.UnderLabel", "");
ssUnderLabelNChar = r.ReadInteger(index++, "StepUsers.UnderLabelNChar", 0);
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
public void ReadIM(ST_f14441a8387aba6d017931caef70dd11Structure r) {
this = r;
}


public static bool operator == (ST_f14441a8387aba6d017931caef70dd11Structure a, ST_f14441a8387aba6d017931caef70dd11Structure b) {
if (a.ssOrder != b.ssOrder) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssUnderLabel != b.ssUnderLabel) return false;
if (a.ssUnderLabelNChar != b.ssUnderLabelNChar) return false;
return true;
}

public static bool operator != (ST_f14441a8387aba6d017931caef70dd11Structure a, ST_f14441a8387aba6d017931caef70dd11Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f14441a8387aba6d017931caef70dd11Structure)) return false;
return (this == (ST_f14441a8387aba6d017931caef70dd11Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssUnderLabel.GetHashCode()
 ^ ssUnderLabelNChar.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f14441a8387aba6d017931caef70dd11Structure Duplicate() {
ST_f14441a8387aba6d017931caef70dd11Structure t;
t.ssOrder = this.ssOrder;
t.ssLabel = this.ssLabel;
t.ssExtendedClass = this.ssExtendedClass;
t.ssUnderLabel = this.ssUnderLabel;
t.ssUnderLabelNChar = this.ssUnderLabelNChar;
t.OptimizedAttributes = null;
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
if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "underlabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnderLabel")) variable.Value = ssUnderLabel; else variable.Optimized = true;
} else if (head == "underlabelnchar") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnderLabelNChar")) variable.Value = ssUnderLabelNChar; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrder) {
return ssOrder;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
if (key == IdUnderLabel) {
return ssUnderLabel;
}
if (key == IdUnderLabelNChar) {
return ssUnderLabelNChar;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
if (attributeKey == IdUnderLabel.Key.AsGuid) {
return ssUnderLabel;
}
if (attributeKey == IdUnderLabelNChar.Key.AsGuid) {
return ssUnderLabelNChar;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrder = (int) other.AttributeGet(IdOrder);
ssLabel = (string) other.AttributeGet(IdLabel);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssUnderLabel = (string) other.AttributeGet(IdUnderLabel);
ssUnderLabelNChar = (int) other.AttributeGet(IdUnderLabelNChar);
}
} // ST_f14441a8387aba6d017931caef70dd11Structure
/// <summary>
/// RecordList type <code>StepUsersList</code> that represents a record list of <code>StepUsers</code>
/// </summary>
public partial class RL_777f2e1f4d594d2e7cb336ad11e846f1 : GenericRecordList<ST_f14441a8387aba6d017931caef70dd11Structure>, IEnumerable, IEnumerator {

protected override ST_f14441a8387aba6d017931caef70dd11Structure GetElementDefaultValue() {
return new ST_f14441a8387aba6d017931caef70dd11Structure();
}

public T[] ToArray<T>(Func<ST_f14441a8387aba6d017931caef70dd11Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_777f2e1f4d594d2e7cb336ad11e846f1 recordList, Func<ST_f14441a8387aba6d017931caef70dd11Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_777f2e1f4d594d2e7cb336ad11e846f1(ST_f14441a8387aba6d017931caef70dd11Structure[] array) {
  RL_777f2e1f4d594d2e7cb336ad11e846f1 result = new RL_777f2e1f4d594d2e7cb336ad11e846f1();
result.InnerFromArray(array);
    return result;
}

public static RL_777f2e1f4d594d2e7cb336ad11e846f1 ToList<T>(T[] array, Func <T, ST_f14441a8387aba6d017931caef70dd11Structure> converter) {
  RL_777f2e1f4d594d2e7cb336ad11e846f1 result = new RL_777f2e1f4d594d2e7cb336ad11e846f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_777f2e1f4d594d2e7cb336ad11e846f1 FromRestList<T>(RestList<T> restList, Func <T, ST_f14441a8387aba6d017931caef70dd11Structure> converter) {
  RL_777f2e1f4d594d2e7cb336ad11e846f1 result = new RL_777f2e1f4d594d2e7cb336ad11e846f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_777f2e1f4d594d2e7cb336ad11e846f1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f14441a8387aba6d017931caef70dd11Structure> NewList() {
return new RL_777f2e1f4d594d2e7cb336ad11e846f1();
}


} // RL_777f2e1f4d594d2e7cb336ad11e846f1
}

