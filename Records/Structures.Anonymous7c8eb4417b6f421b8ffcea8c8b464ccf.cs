namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QbSOfG97G0KP_OqMi0ZMzw)
///  <code>RC_f6cad939346a2d641ae33c13dbcb8a70</code> that represent
/// s <code>ContractFileTypeOrderContractFileOrderFileRecord</code> <p>Description: </p>
/// </summary>
// Name: ContractFileTypeOrderContractFileOrderFileRecord
public partial struct RC_f6cad939346a2d641ae33c13dbcb8a70 : ITypedRecord<RC_f6cad939346a2d641ae33c13dbcb8a70> {
internal static readonly GlobalObjectKey IdContractFileType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+pNubdteqtLSno8Vs_ca6w");
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ls24vaMN4urxcJQolfKjrA");
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NUo5p8E99rc2qs7SCeZhFg");

public EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord ssENContractFileType;

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile;


public BitArray OptimizedAttributes;

public RC_f6cad939346a2d641ae33c13dbcb8a70() {
OptimizedAttributes = null;
ssENContractFileType = new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord();
ssENOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(4,false);
    all[1] = new BitArray(14,false);
    all[2] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENContractFileType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENContractFileType.OptimizedAttributes = value[0];
    ssENOrderContractFile.OptimizedAttributes = value[1];
    ssENOrderFile.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENContractFileType.OptimizedAttributes;
    all[1] = ssENOrderContractFile.OptimizedAttributes;
    all[2] = ssENOrderFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENContractFileType.Read( r, ref index);
ssENOrderContractFile.Read( r, ref index);
ssENOrderFile.Read( r, ref index);
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
public void ReadIM(RC_f6cad939346a2d641ae33c13dbcb8a70 r) {
this = r;
}


public static bool operator == (RC_f6cad939346a2d641ae33c13dbcb8a70 a, RC_f6cad939346a2d641ae33c13dbcb8a70 b) {
if (a.ssENContractFileType != b.ssENContractFileType) return false;
if (a.ssENOrderContractFile != b.ssENOrderContractFile) return false;
if (a.ssENOrderFile != b.ssENOrderFile) return false;
return true;
}

public static bool operator != (RC_f6cad939346a2d641ae33c13dbcb8a70 a, RC_f6cad939346a2d641ae33c13dbcb8a70 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f6cad939346a2d641ae33c13dbcb8a70)) return false;
return (this == (RC_f6cad939346a2d641ae33c13dbcb8a70)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENContractFileType.GetHashCode()
 ^ ssENOrderContractFile.GetHashCode()
 ^ ssENOrderFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENContractFileType.RecursiveReset();
ssENOrderContractFile.RecursiveReset();
ssENOrderFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENContractFileType.InternalRecursiveSave();
ssENOrderContractFile.InternalRecursiveSave();
ssENOrderFile.InternalRecursiveSave();
}


public RC_f6cad939346a2d641ae33c13dbcb8a70 Duplicate() {
RC_f6cad939346a2d641ae33c13dbcb8a70 t;
t.ssENContractFileType = (EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord)this.ssENContractFileType.Duplicate();
t.ssENOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFile.Duplicate();
t.ssENOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFile.Duplicate();
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
if (head == "contractfiletype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractFileType")) variable.Value = ssENContractFileType; else variable.Optimized = true;
variable.SetFieldName("contractfiletype");
} else if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssENOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
} else if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssENOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
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
if (key == IdContractFileType) {
return ssENContractFileType;
}
if (key == IdOrderContractFile) {
return ssENOrderContractFile;
}
if (key == IdOrderFile) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContractFileType.Key.AsGuid) {
return ssENContractFileType;
}
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssENOrderContractFile;
}
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENContractFileType.FillFromOther((IRecord) other.AttributeGet(IdContractFileType));
ssENOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
ssENOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
}
} // RC_f6cad939346a2d641ae33c13dbcb8a70
/// <summary>
/// RecordList type <code>ContractFileTypeOrderContractFileOrderFileRecordList</code> that represents a
///  record list of <code>ContractFileType, OrderContractFile, OrderFile</code>
/// </summary>
public partial class RL_978260cdc25ae86bbfc7a02b4fbbd8c3 : GenericRecordList<RC_f6cad939346a2d641ae33c13dbcb8a70>, IEnumerable, IEnumerator {

protected override RC_f6cad939346a2d641ae33c13dbcb8a70 GetElementDefaultValue() {
return new RC_f6cad939346a2d641ae33c13dbcb8a70();
}

public T[] ToArray<T>(Func<RC_f6cad939346a2d641ae33c13dbcb8a70, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_978260cdc25ae86bbfc7a02b4fbbd8c3 recordList, Func<RC_f6cad939346a2d641ae33c13dbcb8a70, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_978260cdc25ae86bbfc7a02b4fbbd8c3(RC_f6cad939346a2d641ae33c13dbcb8a70[] array) {
  RL_978260cdc25ae86bbfc7a02b4fbbd8c3 result = new RL_978260cdc25ae86bbfc7a02b4fbbd8c3();
result.InnerFromArray(array);
    return result;
}

public static RL_978260cdc25ae86bbfc7a02b4fbbd8c3 ToList<T>(T[] array, Func <T, RC_f6cad939346a2d641ae33c13dbcb8a70> converter) {
  RL_978260cdc25ae86bbfc7a02b4fbbd8c3 result = new RL_978260cdc25ae86bbfc7a02b4fbbd8c3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_978260cdc25ae86bbfc7a02b4fbbd8c3 FromRestList<T>(RestList<T> restList, Func <T, RC_f6cad939346a2d641ae33c13dbcb8a70> converter) {
  RL_978260cdc25ae86bbfc7a02b4fbbd8c3 result = new RL_978260cdc25ae86bbfc7a02b4fbbd8c3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_978260cdc25ae86bbfc7a02b4fbbd8c3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(4,false);
def[1] = new BitArray(14,false);
def[2] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f6cad939346a2d641ae33c13dbcb8a70> NewList() {
return new RL_978260cdc25ae86bbfc7a02b4fbbd8c3();
}


} // RL_978260cdc25ae86bbfc7a02b4fbbd8c3
}

