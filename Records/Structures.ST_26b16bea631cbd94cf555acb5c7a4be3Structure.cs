namespace ssConectaProveedores {
/// <summary>
/// [Structure] RequisitionFileTypesStruct (4464NIpOlUmZemC3XB6o+g)
///  <code>ST_26b16bea631cbd94cf555acb5c7a4be3Structure</code> that represent
/// s <code>RequisitionFileTypesStruct</code> <p>Description: Requisition Files Types Struct.</p>
/// </summary>
// Name: RequisitionFileTypesStruct
public partial struct ST_26b16bea631cbd94cf555acb5c7a4be3Structure : ITypedRecord<ST_26b16bea631cbd94cf555acb5c7a4be3Structure> {
internal static readonly GlobalObjectKey IdRequisitionContractFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*09IERKfXTEORXS5r4seL8w");
internal static readonly GlobalObjectKey IdRequisitionFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NElF5oCs0UWPHpNcXtjp0A");
internal static readonly GlobalObjectKey IdValid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wYkju1NSZkaCJyY55sE1sA");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gdyQqBQEOkqmZdGMw6_TDQ");
internal static readonly GlobalObjectKey IdBigUploadfileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uZmtHCyFIEuoevVZ2rc7MA");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssRequisitionContractFile;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssRequisitionFile;

public ST_b453bea0930035904f55a74692afd3a8Structure ssValid;

public byte[] ssBinary;

public long ssBigUploadfileId;


public BitArray OptimizedAttributes;

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure() {
OptimizedAttributes = null;
ssRequisitionContractFile = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
ssRequisitionFile = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
ssValid = new ST_b453bea0930035904f55a74692afd3a8Structure();
ssBinary = new byte[] {};
ssBigUploadfileId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(9,false);
    all[1] = new BitArray(8,false);
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssRequisitionContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssRequisitionFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssRequisitionContractFile.OptimizedAttributes = value[0];
    ssRequisitionFile.OptimizedAttributes = value[1];
    ssValid.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssRequisitionContractFile.OptimizedAttributes;
    all[1] = ssRequisitionFile.OptimizedAttributes;
    all[2] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssBinary = r.ReadBinaryData(index++, "RequisitionFileTypesStruct.Binary", new byte[] {});
ssBigUploadfileId = r.ReadLongInteger(index++, "RequisitionFileTypesStruct.BigUploadfileId", 0L);
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
public void ReadIM(ST_26b16bea631cbd94cf555acb5c7a4be3Structure r) {
this = r;
}


public static bool operator == (ST_26b16bea631cbd94cf555acb5c7a4be3Structure a, ST_26b16bea631cbd94cf555acb5c7a4be3Structure b) {
if (a.ssRequisitionContractFile != b.ssRequisitionContractFile) return false;
if (a.ssRequisitionFile != b.ssRequisitionFile) return false;
if (a.ssValid != b.ssValid) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
if (a.ssBigUploadfileId != b.ssBigUploadfileId) return false;
return true;
}

public static bool operator != (ST_26b16bea631cbd94cf555acb5c7a4be3Structure a, ST_26b16bea631cbd94cf555acb5c7a4be3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_26b16bea631cbd94cf555acb5c7a4be3Structure)) return false;
return (this == (ST_26b16bea631cbd94cf555acb5c7a4be3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRequisitionContractFile.GetHashCode()
 ^ ssRequisitionFile.GetHashCode()
 ^ ssValid.GetHashCode()
 ^ ssBinary.GetHashCode()
 ^ ssBigUploadfileId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssRequisitionContractFile.RecursiveReset();
ssRequisitionFile.RecursiveReset();
ssValid.RecursiveReset();
}

public void InternalRecursiveSave() {
ssRequisitionContractFile.InternalRecursiveSave();
ssRequisitionFile.InternalRecursiveSave();
ssValid.InternalRecursiveSave();
}


public ST_26b16bea631cbd94cf555acb5c7a4be3Structure Duplicate() {
ST_26b16bea631cbd94cf555acb5c7a4be3Structure t;
t.ssRequisitionContractFile = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssRequisitionContractFile.Duplicate();
t.ssRequisitionFile = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssRequisitionFile.Duplicate();
t.ssValid = (ST_b453bea0930035904f55a74692afd3a8Structure)this.ssValid.Duplicate();
t.ssBinary = this.ssBinary;
t.ssBigUploadfileId = this.ssBigUploadfileId;
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionContractFile")) variable.Value = ssRequisitionContractFile; else variable.Optimized = true;
variable.SetFieldName("requisitioncontractfile");
} else if (head == "requisitionfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile")) variable.Value = ssRequisitionFile; else variable.Optimized = true;
variable.SetFieldName("requisitionfile");
} else if (head == "valid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Valid")) variable.Value = ssValid; else variable.Optimized = true;
variable.SetFieldName("valid");
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
} else if (head == "biguploadfileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BigUploadfileId")) variable.Value = ssBigUploadfileId; else variable.Optimized = true;
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
return ssRequisitionContractFile;
}
if (key == IdRequisitionFile) {
return ssRequisitionFile;
}
if (key == IdValid) {
return ssValid;
}
if (key == IdBinary) {
return ssBinary;
}
if (key == IdBigUploadfileId) {
return ssBigUploadfileId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFile.Key.AsGuid) {
return ssRequisitionContractFile;
}
if (attributeKey == IdRequisitionFile.Key.AsGuid) {
return ssRequisitionFile;
}
if (attributeKey == IdValid.Key.AsGuid) {
return ssValid;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
}
if (attributeKey == IdBigUploadfileId.Key.AsGuid) {
return ssBigUploadfileId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRequisitionContractFile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFile));
ssRequisitionFile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile));
ssValid.FillFromOther((IRecord) other.AttributeGet(IdValid));
ssBinary = (byte[]) other.AttributeGet(IdBinary);
ssBigUploadfileId = (long) other.AttributeGet(IdBigUploadfileId);
}
} // ST_26b16bea631cbd94cf555acb5c7a4be3Structure
/// <summary>
/// RecordList type <code>RequisitionFileTypesStructList</code> that represents a record list of
///  <code>RequisitionFileTypesStruct</code>
/// </summary>
public partial class RL_7a479a555821b093171c5d3cd3382006 : GenericRecordList<ST_26b16bea631cbd94cf555acb5c7a4be3Structure>, IEnumerable, IEnumerator {

protected override ST_26b16bea631cbd94cf555acb5c7a4be3Structure GetElementDefaultValue() {
return new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();
}

public T[] ToArray<T>(Func<ST_26b16bea631cbd94cf555acb5c7a4be3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7a479a555821b093171c5d3cd3382006 recordList, Func<ST_26b16bea631cbd94cf555acb5c7a4be3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7a479a555821b093171c5d3cd3382006(ST_26b16bea631cbd94cf555acb5c7a4be3Structure[] array) {
  RL_7a479a555821b093171c5d3cd3382006 result = new RL_7a479a555821b093171c5d3cd3382006();
result.InnerFromArray(array);
    return result;
}

public static RL_7a479a555821b093171c5d3cd3382006 ToList<T>(T[] array, Func <T, ST_26b16bea631cbd94cf555acb5c7a4be3Structure> converter) {
  RL_7a479a555821b093171c5d3cd3382006 result = new RL_7a479a555821b093171c5d3cd3382006();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7a479a555821b093171c5d3cd3382006 FromRestList<T>(RestList<T> restList, Func <T, ST_26b16bea631cbd94cf555acb5c7a4be3Structure> converter) {
  RL_7a479a555821b093171c5d3cd3382006 result = new RL_7a479a555821b093171c5d3cd3382006();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7a479a555821b093171c5d3cd3382006() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(9,false);
def[1] = new BitArray(8,false);
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_26b16bea631cbd94cf555acb5c7a4be3Structure> NewList() {
return new RL_7a479a555821b093171c5d3cd3382006();
}


} // RL_7a479a555821b093171c5d3cd3382006
}

