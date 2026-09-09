namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MdAGQaqAtEWTfyzGLyIH9w)
///  <code>RC_38cfa4b424b01ab9c089e700fede9b7d</code> that represent
/// s <code>RequisitionAccountingRequisitionFile2Record</code> <p>Description: </p>
/// </summary>
// Name: RequisitionAccountingRequisitionFile2Record
public partial struct RC_38cfa4b424b01ab9c089e700fede9b7d : ITypedRecord<RC_38cfa4b424b01ab9c089e700fede9b7d> {
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");
internal static readonly GlobalObjectKey IdRequisitionFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NbYPPv7ugJRU+nVCFUapAQ");

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2;


public BitArray OptimizedAttributes;

public RC_38cfa4b424b01ab9c089e700fede9b7d() {
OptimizedAttributes = null;
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
ssENRequisitionFile2 = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionFile2.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionAccounting.OptimizedAttributes = value[0];
    ssENRequisitionFile2.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionAccounting.OptimizedAttributes;
    all[1] = ssENRequisitionFile2.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionAccounting.Read( r, ref index);
ssENRequisitionFile2.Read( r, ref index);
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
public void ReadIM(RC_38cfa4b424b01ab9c089e700fede9b7d r) {
this = r;
}


public static bool operator == (RC_38cfa4b424b01ab9c089e700fede9b7d a, RC_38cfa4b424b01ab9c089e700fede9b7d b) {
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
if (a.ssENRequisitionFile2 != b.ssENRequisitionFile2) return false;
return true;
}

public static bool operator != (RC_38cfa4b424b01ab9c089e700fede9b7d a, RC_38cfa4b424b01ab9c089e700fede9b7d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_38cfa4b424b01ab9c089e700fede9b7d)) return false;
return (this == (RC_38cfa4b424b01ab9c089e700fede9b7d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
 ^ ssENRequisitionFile2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionAccounting.RecursiveReset();
ssENRequisitionFile2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionAccounting.InternalRecursiveSave();
ssENRequisitionFile2.InternalRecursiveSave();
}


public RC_38cfa4b424b01ab9c089e700fede9b7d Duplicate() {
RC_38cfa4b424b01ab9c089e700fede9b7d t;
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
t.ssENRequisitionFile2 = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssENRequisitionFile2.Duplicate();
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
if (head == "requisitionaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccounting")) variable.Value = ssENRequisitionAccounting; else variable.Optimized = true;
variable.SetFieldName("requisitionaccounting");
} else if (head == "requisitionfile2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile2")) variable.Value = ssENRequisitionFile2; else variable.Optimized = true;
variable.SetFieldName("requisitionfile2");
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
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
}
if (key == IdRequisitionFile2) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
}
if (attributeKey == IdRequisitionFile2.Key.AsGuid) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
ssENRequisitionFile2.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2));
}
} // RC_38cfa4b424b01ab9c089e700fede9b7d
/// <summary>
/// RecordList type <code>RequisitionAccountingRequisitionFile2RecordList</code> that represents a
///  record list of <code>RequisitionAccounting, RequisitionFile2</code>
/// </summary>
public partial class RL_c42d15199149a00cb6f1dfb46d2f46c3 : GenericRecordList<RC_38cfa4b424b01ab9c089e700fede9b7d>, IEnumerable, IEnumerator {

protected override RC_38cfa4b424b01ab9c089e700fede9b7d GetElementDefaultValue() {
return new RC_38cfa4b424b01ab9c089e700fede9b7d();
}

public T[] ToArray<T>(Func<RC_38cfa4b424b01ab9c089e700fede9b7d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c42d15199149a00cb6f1dfb46d2f46c3 recordList, Func<RC_38cfa4b424b01ab9c089e700fede9b7d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c42d15199149a00cb6f1dfb46d2f46c3(RC_38cfa4b424b01ab9c089e700fede9b7d[] array) {
  RL_c42d15199149a00cb6f1dfb46d2f46c3 result = new RL_c42d15199149a00cb6f1dfb46d2f46c3();
result.InnerFromArray(array);
    return result;
}

public static RL_c42d15199149a00cb6f1dfb46d2f46c3 ToList<T>(T[] array, Func <T, RC_38cfa4b424b01ab9c089e700fede9b7d> converter) {
  RL_c42d15199149a00cb6f1dfb46d2f46c3 result = new RL_c42d15199149a00cb6f1dfb46d2f46c3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c42d15199149a00cb6f1dfb46d2f46c3 FromRestList<T>(RestList<T> restList, Func <T, RC_38cfa4b424b01ab9c089e700fede9b7d> converter) {
  RL_c42d15199149a00cb6f1dfb46d2f46c3 result = new RL_c42d15199149a00cb6f1dfb46d2f46c3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c42d15199149a00cb6f1dfb46d2f46c3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(19,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_38cfa4b424b01ab9c089e700fede9b7d> NewList() {
return new RL_c42d15199149a00cb6f1dfb46d2f46c3();
}


} // RL_c42d15199149a00cb6f1dfb46d2f46c3
}

