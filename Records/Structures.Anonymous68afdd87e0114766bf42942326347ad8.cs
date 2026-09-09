namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (h92vaBHgZke_QpQjJjR62A)
///  <code>RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8</code> that represent
/// s <code>WizardApprovalDisplayRecord</code> <p>Description: </p>
/// </summary>
// Name: WizardApprovalDisplayRecord
public partial struct RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 : ITypedRecord<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> {
internal static readonly GlobalObjectKey IdWizardApprovalDisplay = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d83Cp8kN_OI+C9_S2Zo4uA");

public ST_3c480a6d17a69eed60b057b7ed343a1dStructure ssSTWizardApprovalDisplay;


public static implicit operator ST_3c480a6d17a69eed60b057b7ed343a1dStructure( RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 r) {
return r.ssSTWizardApprovalDisplay;
}

public static implicit operator RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 (ST_3c480a6d17a69eed60b057b7ed343a1dStructure r) {
RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 res = new RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 ();
res.ssSTWizardApprovalDisplay = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8() {
OptimizedAttributes = null;
ssSTWizardApprovalDisplay = new ST_3c480a6d17a69eed60b057b7ed343a1dStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTWizardApprovalDisplay.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTWizardApprovalDisplay.Read( r, ref index);
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
public void ReadIM(RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 r) {
this = r;
}


public static bool operator == (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 a, RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 b) {
if (a.ssSTWizardApprovalDisplay != b.ssSTWizardApprovalDisplay) return false;
return true;
}

public static bool operator != (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 a, RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8)) return false;
return (this == (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTWizardApprovalDisplay.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTWizardApprovalDisplay.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTWizardApprovalDisplay.InternalRecursiveSave();
}


public RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 Duplicate() {
RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 t;
t.ssSTWizardApprovalDisplay = (ST_3c480a6d17a69eed60b057b7ed343a1dStructure)this.ssSTWizardApprovalDisplay.Duplicate();
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
if (head == "wizardapprovaldisplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WizardApprovalDisplay")) variable.Value = ssSTWizardApprovalDisplay; else variable.Optimized = true;
variable.SetFieldName("wizardapprovaldisplay");
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
if (key == IdWizardApprovalDisplay) {
return ssSTWizardApprovalDisplay;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWizardApprovalDisplay.Key.AsGuid) {
return ssSTWizardApprovalDisplay;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTWizardApprovalDisplay.FillFromOther((IRecord) other.AttributeGet(IdWizardApprovalDisplay));
}
} // RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8
/// <summary>
/// RecordList type <code>WizardApprovalDisplayRecordList</code> that represents a record list of
///  <code>WizardApprovalDisplay</code>
/// </summary>
public partial class RL_be474dab9f20512d09fda3e1e99c2e25 : GenericRecordList<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8>, IEnumerable, IEnumerator {

protected override RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 GetElementDefaultValue() {
return new RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8();
}

public T[] ToArray<T>(Func<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_be474dab9f20512d09fda3e1e99c2e25 recordList, Func<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_be474dab9f20512d09fda3e1e99c2e25(RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8[] array) {
  RL_be474dab9f20512d09fda3e1e99c2e25 result = new RL_be474dab9f20512d09fda3e1e99c2e25();
result.InnerFromArray(array);
    return result;
}

public static RL_be474dab9f20512d09fda3e1e99c2e25 ToList<T>(T[] array, Func <T, RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> converter) {
  RL_be474dab9f20512d09fda3e1e99c2e25 result = new RL_be474dab9f20512d09fda3e1e99c2e25();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_be474dab9f20512d09fda3e1e99c2e25 FromRestList<T>(RestList<T> restList, Func <T, RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> converter) {
  RL_be474dab9f20512d09fda3e1e99c2e25 result = new RL_be474dab9f20512d09fda3e1e99c2e25();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_be474dab9f20512d09fda3e1e99c2e25() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> NewList() {
return new RL_be474dab9f20512d09fda3e1e99c2e25();
}


} // RL_be474dab9f20512d09fda3e1e99c2e25
}

