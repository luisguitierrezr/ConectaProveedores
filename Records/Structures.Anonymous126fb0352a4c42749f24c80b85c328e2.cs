namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NbBvEkwqdEKfJMgLhcMo4g)
///  <code>RC_065973fb437991de65b823e42c10f6b8</code> that represent
/// s <code>RequisitionListExport_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionListExport_StructRecord
public partial struct RC_065973fb437991de65b823e42c10f6b8 : ITypedRecord<RC_065973fb437991de65b823e42c10f6b8> {
internal static readonly GlobalObjectKey IdRequisitionListExport_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+3NZBnlD3pFluCPkLBD2uA");

public ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure ssSTRequisitionListExport_Struct;


public static implicit operator ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure( RC_065973fb437991de65b823e42c10f6b8 r) {
return r.ssSTRequisitionListExport_Struct;
}

public static implicit operator RC_065973fb437991de65b823e42c10f6b8 (ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure r) {
RC_065973fb437991de65b823e42c10f6b8 res = new RC_065973fb437991de65b823e42c10f6b8 ();
res.ssSTRequisitionListExport_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_065973fb437991de65b823e42c10f6b8() {
OptimizedAttributes = null;
ssSTRequisitionListExport_Struct = new ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure();
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
    ssSTRequisitionListExport_Struct.OptimizedAttributes = value[0];
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
ssSTRequisitionListExport_Struct.Read( r, ref index);
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
public void ReadIM(RC_065973fb437991de65b823e42c10f6b8 r) {
this = r;
}


public static bool operator == (RC_065973fb437991de65b823e42c10f6b8 a, RC_065973fb437991de65b823e42c10f6b8 b) {
if (a.ssSTRequisitionListExport_Struct != b.ssSTRequisitionListExport_Struct) return false;
return true;
}

public static bool operator != (RC_065973fb437991de65b823e42c10f6b8 a, RC_065973fb437991de65b823e42c10f6b8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_065973fb437991de65b823e42c10f6b8)) return false;
return (this == (RC_065973fb437991de65b823e42c10f6b8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRequisitionListExport_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRequisitionListExport_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRequisitionListExport_Struct.InternalRecursiveSave();
}


public RC_065973fb437991de65b823e42c10f6b8 Duplicate() {
RC_065973fb437991de65b823e42c10f6b8 t;
t.ssSTRequisitionListExport_Struct = (ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure)this.ssSTRequisitionListExport_Struct.Duplicate();
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
if (head == "requisitionlistexport_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionListExport_Struct")) variable.Value = ssSTRequisitionListExport_Struct; else variable.Optimized = true;
variable.SetFieldName("requisitionlistexport_struct");
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
if (key == IdRequisitionListExport_Struct) {
return ssSTRequisitionListExport_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionListExport_Struct.Key.AsGuid) {
return ssSTRequisitionListExport_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRequisitionListExport_Struct.FillFromOther((IRecord) other.AttributeGet(IdRequisitionListExport_Struct));
}
} // RC_065973fb437991de65b823e42c10f6b8
/// <summary>
/// RecordList type <code>RequisitionListExport_StructRecordList</code> that represents a record list
///  of <code>RequisitionListExport_Struct</code>
/// </summary>
public partial class RL_9ede71d9c6d03aba8c5ee336f1d0813f : GenericRecordList<RC_065973fb437991de65b823e42c10f6b8>, IEnumerable, IEnumerator {

protected override RC_065973fb437991de65b823e42c10f6b8 GetElementDefaultValue() {
return new RC_065973fb437991de65b823e42c10f6b8();
}

public T[] ToArray<T>(Func<RC_065973fb437991de65b823e42c10f6b8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9ede71d9c6d03aba8c5ee336f1d0813f recordList, Func<RC_065973fb437991de65b823e42c10f6b8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9ede71d9c6d03aba8c5ee336f1d0813f(RC_065973fb437991de65b823e42c10f6b8[] array) {
  RL_9ede71d9c6d03aba8c5ee336f1d0813f result = new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
result.InnerFromArray(array);
    return result;
}

public static RL_9ede71d9c6d03aba8c5ee336f1d0813f ToList<T>(T[] array, Func <T, RC_065973fb437991de65b823e42c10f6b8> converter) {
  RL_9ede71d9c6d03aba8c5ee336f1d0813f result = new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9ede71d9c6d03aba8c5ee336f1d0813f FromRestList<T>(RestList<T> restList, Func <T, RC_065973fb437991de65b823e42c10f6b8> converter) {
  RL_9ede71d9c6d03aba8c5ee336f1d0813f result = new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9ede71d9c6d03aba8c5ee336f1d0813f() : base() {
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
protected override OSList<RC_065973fb437991de65b823e42c10f6b8> NewList() {
return new RL_9ede71d9c6d03aba8c5ee336f1d0813f();
}


} // RL_9ede71d9c6d03aba8c5ee336f1d0813f
}

