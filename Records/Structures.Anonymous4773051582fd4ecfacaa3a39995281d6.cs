namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FQVzR_2Cz06sqjo5mVKB1g)
///  <code>RC_508355980a3676af946819914b6b1546</code> that represent
/// s <code>RequisitionCostCenterRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionCostCenterRecord
public partial struct RC_508355980a3676af946819914b6b1546 : ITypedRecord<RC_508355980a3676af946819914b6b1546> {
internal static readonly GlobalObjectKey IdRequisitionCostCenter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mFWDUDYKr3aUaBmRS2sVRg");

public EN_114fcf95674648310a3efb0d78529a37EntityRecord ssENRequisitionCostCenter;


public static implicit operator EN_114fcf95674648310a3efb0d78529a37EntityRecord( RC_508355980a3676af946819914b6b1546 r) {
return r.ssENRequisitionCostCenter;
}

public static implicit operator RC_508355980a3676af946819914b6b1546 (EN_114fcf95674648310a3efb0d78529a37EntityRecord r) {
RC_508355980a3676af946819914b6b1546 res = new RC_508355980a3676af946819914b6b1546 ();
res.ssENRequisitionCostCenter = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionCostCenter.ChangedAttributes = value;
}
get {
    return ssENRequisitionCostCenter.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_508355980a3676af946819914b6b1546() {
OptimizedAttributes = null;
ssENRequisitionCostCenter = new EN_114fcf95674648310a3efb0d78529a37EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionCostCenter.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionCostCenter.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionCostCenter.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionCostCenter.Read( r, ref index);
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
public void ReadIM(RC_508355980a3676af946819914b6b1546 r) {
this = r;
}


public static bool operator == (RC_508355980a3676af946819914b6b1546 a, RC_508355980a3676af946819914b6b1546 b) {
if (a.ssENRequisitionCostCenter != b.ssENRequisitionCostCenter) return false;
return true;
}

public static bool operator != (RC_508355980a3676af946819914b6b1546 a, RC_508355980a3676af946819914b6b1546 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_508355980a3676af946819914b6b1546)) return false;
return (this == (RC_508355980a3676af946819914b6b1546)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionCostCenter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionCostCenter.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionCostCenter.InternalRecursiveSave();
}


public RC_508355980a3676af946819914b6b1546 Duplicate() {
RC_508355980a3676af946819914b6b1546 t;
t.ssENRequisitionCostCenter = (EN_114fcf95674648310a3efb0d78529a37EntityRecord)this.ssENRequisitionCostCenter.Duplicate();
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
if (head == "requisitioncostcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionCostCenter")) variable.Value = ssENRequisitionCostCenter; else variable.Optimized = true;
variable.SetFieldName("requisitioncostcenter");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionCostCenter.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionCostCenter.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionCostCenter) {
return ssENRequisitionCostCenter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionCostCenter.Key.AsGuid) {
return ssENRequisitionCostCenter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionCostCenter.FillFromOther((IRecord) other.AttributeGet(IdRequisitionCostCenter));
}
} // RC_508355980a3676af946819914b6b1546
/// <summary>
/// RecordList type <code>RequisitionCostCenterRecordList</code> that represents a record list of
///  <code>RequisitionCostCenter</code>
/// </summary>
public partial class RL_d3e0bac8462c62ccd7f8cc475394c310 : GenericRecordList<RC_508355980a3676af946819914b6b1546>, IEnumerable, IEnumerator {

protected override RC_508355980a3676af946819914b6b1546 GetElementDefaultValue() {
return new RC_508355980a3676af946819914b6b1546();
}

public T[] ToArray<T>(Func<RC_508355980a3676af946819914b6b1546, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d3e0bac8462c62ccd7f8cc475394c310 recordList, Func<RC_508355980a3676af946819914b6b1546, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d3e0bac8462c62ccd7f8cc475394c310(RC_508355980a3676af946819914b6b1546[] array) {
  RL_d3e0bac8462c62ccd7f8cc475394c310 result = new RL_d3e0bac8462c62ccd7f8cc475394c310();
result.InnerFromArray(array);
    return result;
}

public static RL_d3e0bac8462c62ccd7f8cc475394c310 ToList<T>(T[] array, Func <T, RC_508355980a3676af946819914b6b1546> converter) {
  RL_d3e0bac8462c62ccd7f8cc475394c310 result = new RL_d3e0bac8462c62ccd7f8cc475394c310();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d3e0bac8462c62ccd7f8cc475394c310 FromRestList<T>(RestList<T> restList, Func <T, RC_508355980a3676af946819914b6b1546> converter) {
  RL_d3e0bac8462c62ccd7f8cc475394c310 result = new RL_d3e0bac8462c62ccd7f8cc475394c310();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d3e0bac8462c62ccd7f8cc475394c310() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_508355980a3676af946819914b6b1546> NewList() {
return new RL_d3e0bac8462c62ccd7f8cc475394c310();
}


} // RL_d3e0bac8462c62ccd7f8cc475394c310
}

