namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1pg5bYCCE0C1MdYWcvyBjA)
///  <code>RC_ac566b5b63768f933fd7207ce4399046</code> that represent
/// s <code>RequisitionContractFileForeignResidenceRequisitionFile2ForeignResidenceRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: RequisitionContractFileForeignResidenceRequisitionFile2ForeignResidenceRecord
public partial struct RC_ac566b5b63768f933fd7207ce4399046 : ITypedRecord<RC_ac566b5b63768f933fd7207ce4399046> {
internal static readonly GlobalObjectKey IdRequisitionContractFileForeignResidence = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_qwC1QjfqPQhXRPsBUOD4g");
internal static readonly GlobalObjectKey IdRequisitionFile2ForeignResidence = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6lwZnQgHzq0QQnfb+EPDew");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFileForeignResidence;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2ForeignResidence;


public BitArray OptimizedAttributes;

public RC_ac566b5b63768f933fd7207ce4399046() {
OptimizedAttributes = null;
ssENRequisitionContractFileForeignResidence = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
ssENRequisitionFile2ForeignResidence = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(9,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionContractFileForeignResidence.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionFile2ForeignResidence.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionContractFileForeignResidence.OptimizedAttributes = value[0];
    ssENRequisitionFile2ForeignResidence.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionContractFileForeignResidence.OptimizedAttributes;
    all[1] = ssENRequisitionFile2ForeignResidence.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionContractFileForeignResidence.Read( r, ref index);
ssENRequisitionFile2ForeignResidence.Read( r, ref index);
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
public void ReadIM(RC_ac566b5b63768f933fd7207ce4399046 r) {
this = r;
}


public static bool operator == (RC_ac566b5b63768f933fd7207ce4399046 a, RC_ac566b5b63768f933fd7207ce4399046 b) {
if (a.ssENRequisitionContractFileForeignResidence != b.ssENRequisitionContractFileForeignResidence) return false;
if (a.ssENRequisitionFile2ForeignResidence != b.ssENRequisitionFile2ForeignResidence) return false;
return true;
}

public static bool operator != (RC_ac566b5b63768f933fd7207ce4399046 a, RC_ac566b5b63768f933fd7207ce4399046 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ac566b5b63768f933fd7207ce4399046)) return false;
return (this == (RC_ac566b5b63768f933fd7207ce4399046)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionContractFileForeignResidence.GetHashCode()
 ^ ssENRequisitionFile2ForeignResidence.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionContractFileForeignResidence.RecursiveReset();
ssENRequisitionFile2ForeignResidence.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionContractFileForeignResidence.InternalRecursiveSave();
ssENRequisitionFile2ForeignResidence.InternalRecursiveSave();
}


public RC_ac566b5b63768f933fd7207ce4399046 Duplicate() {
RC_ac566b5b63768f933fd7207ce4399046 t;
t.ssENRequisitionContractFileForeignResidence = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssENRequisitionContractFileForeignResidence.Duplicate();
t.ssENRequisitionFile2ForeignResidence = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssENRequisitionFile2ForeignResidence.Duplicate();
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
if (head == "requisitioncontractfileforeignresidence") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionContractFileForeignResidence")) variable.Value = ssENRequisitionContractFileForeignResidence; else variable.Optimized = true;
variable.SetFieldName("requisitioncontractfileforeignresidence");
} else if (head == "requisitionfile2foreignresidence") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile2ForeignResidence")) variable.Value = ssENRequisitionFile2ForeignResidence; else variable.Optimized = true;
variable.SetFieldName("requisitionfile2foreignresidence");
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
if (key == IdRequisitionContractFileForeignResidence) {
return ssENRequisitionContractFileForeignResidence;
}
if (key == IdRequisitionFile2ForeignResidence) {
return ssENRequisitionFile2ForeignResidence;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFileForeignResidence.Key.AsGuid) {
return ssENRequisitionContractFileForeignResidence;
}
if (attributeKey == IdRequisitionFile2ForeignResidence.Key.AsGuid) {
return ssENRequisitionFile2ForeignResidence;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionContractFileForeignResidence.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFileForeignResidence));
ssENRequisitionFile2ForeignResidence.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2ForeignResidence));
}
} // RC_ac566b5b63768f933fd7207ce4399046
/// <summary>
/// RecordList type
///  <code>RequisitionContractFileForeignResidenceRequisitionFile2ForeignResidenceRecordList</code> tha
/// t represents a record list of <code>RequisitionContractFile, RequisitionFile2</code>
/// </summary>
public partial class RL_bb2966aa0324244d136f889c366ee0f8 : GenericRecordList<RC_ac566b5b63768f933fd7207ce4399046>, IEnumerable, IEnumerator {

protected override RC_ac566b5b63768f933fd7207ce4399046 GetElementDefaultValue() {
return new RC_ac566b5b63768f933fd7207ce4399046();
}

public T[] ToArray<T>(Func<RC_ac566b5b63768f933fd7207ce4399046, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb2966aa0324244d136f889c366ee0f8 recordList, Func<RC_ac566b5b63768f933fd7207ce4399046, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb2966aa0324244d136f889c366ee0f8(RC_ac566b5b63768f933fd7207ce4399046[] array) {
  RL_bb2966aa0324244d136f889c366ee0f8 result = new RL_bb2966aa0324244d136f889c366ee0f8();
result.InnerFromArray(array);
    return result;
}

public static RL_bb2966aa0324244d136f889c366ee0f8 ToList<T>(T[] array, Func <T, RC_ac566b5b63768f933fd7207ce4399046> converter) {
  RL_bb2966aa0324244d136f889c366ee0f8 result = new RL_bb2966aa0324244d136f889c366ee0f8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb2966aa0324244d136f889c366ee0f8 FromRestList<T>(RestList<T> restList, Func <T, RC_ac566b5b63768f933fd7207ce4399046> converter) {
  RL_bb2966aa0324244d136f889c366ee0f8 result = new RL_bb2966aa0324244d136f889c366ee0f8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb2966aa0324244d136f889c366ee0f8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(9,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ac566b5b63768f933fd7207ce4399046> NewList() {
return new RL_bb2966aa0324244d136f889c366ee0f8();
}


} // RL_bb2966aa0324244d136f889c366ee0f8
}

