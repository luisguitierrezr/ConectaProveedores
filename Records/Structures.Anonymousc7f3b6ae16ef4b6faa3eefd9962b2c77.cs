namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rrbzx+8Wb0uqPu_Zlissdw)
///  <code>RC_dc345357879dcb92e41eacae4ac8926c</code> that represent
/// s <code>RequisitionContractFileRequisitionFile2Record</code> <p>Description: </p>
/// </summary>
// Name: RequisitionContractFileRequisitionFile2Record
public partial struct RC_dc345357879dcb92e41eacae4ac8926c : ITypedRecord<RC_dc345357879dcb92e41eacae4ac8926c> {
internal static readonly GlobalObjectKey IdRequisitionContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QcYeR2FJwD6p81JfwtnhHA");
internal static readonly GlobalObjectKey IdRequisitionFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NbYPPv7ugJRU+nVCFUapAQ");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2;


public BitArray OptimizedAttributes;

public RC_dc345357879dcb92e41eacae4ac8926c() {
OptimizedAttributes = null;
ssENRequisitionContractFile = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
ssENRequisitionFile2 = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
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
    ssENRequisitionContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionFile2.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionContractFile.OptimizedAttributes = value[0];
    ssENRequisitionFile2.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionContractFile.OptimizedAttributes;
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
ssENRequisitionContractFile.Read( r, ref index);
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
public void ReadIM(RC_dc345357879dcb92e41eacae4ac8926c r) {
this = r;
}


public static bool operator == (RC_dc345357879dcb92e41eacae4ac8926c a, RC_dc345357879dcb92e41eacae4ac8926c b) {
if (a.ssENRequisitionContractFile != b.ssENRequisitionContractFile) return false;
if (a.ssENRequisitionFile2 != b.ssENRequisitionFile2) return false;
return true;
}

public static bool operator != (RC_dc345357879dcb92e41eacae4ac8926c a, RC_dc345357879dcb92e41eacae4ac8926c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dc345357879dcb92e41eacae4ac8926c)) return false;
return (this == (RC_dc345357879dcb92e41eacae4ac8926c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionContractFile.GetHashCode()
 ^ ssENRequisitionFile2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionContractFile.RecursiveReset();
ssENRequisitionFile2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionContractFile.InternalRecursiveSave();
ssENRequisitionFile2.InternalRecursiveSave();
}


public RC_dc345357879dcb92e41eacae4ac8926c Duplicate() {
RC_dc345357879dcb92e41eacae4ac8926c t;
t.ssENRequisitionContractFile = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssENRequisitionContractFile.Duplicate();
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
if (head == "requisitioncontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionContractFile")) variable.Value = ssENRequisitionContractFile; else variable.Optimized = true;
variable.SetFieldName("requisitioncontractfile");
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
if (key == IdRequisitionContractFile) {
return ssENRequisitionContractFile;
}
if (key == IdRequisitionFile2) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFile.Key.AsGuid) {
return ssENRequisitionContractFile;
}
if (attributeKey == IdRequisitionFile2.Key.AsGuid) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionContractFile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFile));
ssENRequisitionFile2.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2));
}
} // RC_dc345357879dcb92e41eacae4ac8926c
/// <summary>
/// RecordList type <code>RequisitionContractFileRequisitionFile2RecordList</code> that represents a
///  record list of <code>RequisitionContractFile, RequisitionFile2</code>
/// </summary>
public partial class RL_dcf9165e080aea63f7a9b95efcf09ef4 : GenericRecordList<RC_dc345357879dcb92e41eacae4ac8926c>, IEnumerable, IEnumerator {

protected override RC_dc345357879dcb92e41eacae4ac8926c GetElementDefaultValue() {
return new RC_dc345357879dcb92e41eacae4ac8926c();
}

public T[] ToArray<T>(Func<RC_dc345357879dcb92e41eacae4ac8926c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dcf9165e080aea63f7a9b95efcf09ef4 recordList, Func<RC_dc345357879dcb92e41eacae4ac8926c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dcf9165e080aea63f7a9b95efcf09ef4(RC_dc345357879dcb92e41eacae4ac8926c[] array) {
  RL_dcf9165e080aea63f7a9b95efcf09ef4 result = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
result.InnerFromArray(array);
    return result;
}

public static RL_dcf9165e080aea63f7a9b95efcf09ef4 ToList<T>(T[] array, Func <T, RC_dc345357879dcb92e41eacae4ac8926c> converter) {
  RL_dcf9165e080aea63f7a9b95efcf09ef4 result = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dcf9165e080aea63f7a9b95efcf09ef4 FromRestList<T>(RestList<T> restList, Func <T, RC_dc345357879dcb92e41eacae4ac8926c> converter) {
  RL_dcf9165e080aea63f7a9b95efcf09ef4 result = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dcf9165e080aea63f7a9b95efcf09ef4() : base() {
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
protected override OSList<RC_dc345357879dcb92e41eacae4ac8926c> NewList() {
return new RL_dcf9165e080aea63f7a9b95efcf09ef4();
}


} // RL_dcf9165e080aea63f7a9b95efcf09ef4
}

