namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderFileTypesStruct (CTzY_KuocUaRuD7Ezd2i0Q)
///  <code>ST_c3df6a1f053620bf8d50da58ff4e41bcStructure</code> that represent
/// s <code>OrderFileTypesStruct</code> <p>Description: Order Files Types Struct.</p>
/// </summary>
// Name: OrderFileTypesStruct
public partial struct ST_c3df6a1f053620bf8d50da58ff4e41bcStructure : ITypedRecord<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> {
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ONbtLhEGwEGWFbge+ayTOA");
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*d1MXAFOcXUSv5dTmQPwCkA");
internal static readonly GlobalObjectKey IdValid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6e2_BR6y50Wf_GoWtHRwGg");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t2lRPEeWTUiO6v3+S3SIHA");

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssOrderContractFile;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssOrderFile;

public ST_b453bea0930035904f55a74692afd3a8Structure ssValid;

public byte[] ssBinary;


public BitArray OptimizedAttributes;

public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure() {
OptimizedAttributes = null;
ssOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
ssValid = new ST_b453bea0930035904f55a74692afd3a8Structure();
ssBinary = new byte[] {};
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(8,false);
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssOrderContractFile.OptimizedAttributes = value[0];
    ssOrderFile.OptimizedAttributes = value[1];
    ssValid.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssOrderContractFile.OptimizedAttributes;
    all[1] = ssOrderFile.OptimizedAttributes;
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
ssBinary = r.ReadBinaryData(index++, "OrderFileTypesStruct.Binary", new byte[] {});
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
public void ReadIM(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure r) {
this = r;
}


public static bool operator == (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure a, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure b) {
if (a.ssOrderContractFile != b.ssOrderContractFile) return false;
if (a.ssOrderFile != b.ssOrderFile) return false;
if (a.ssValid != b.ssValid) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
return true;
}

public static bool operator != (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure a, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)) return false;
return (this == (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderContractFile.GetHashCode()
 ^ ssOrderFile.GetHashCode()
 ^ ssValid.GetHashCode()
 ^ ssBinary.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOrderContractFile.RecursiveReset();
ssOrderFile.RecursiveReset();
ssValid.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOrderContractFile.InternalRecursiveSave();
ssOrderFile.InternalRecursiveSave();
ssValid.InternalRecursiveSave();
}


public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure Duplicate() {
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure t;
t.ssOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssOrderContractFile.Duplicate();
t.ssOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssOrderFile.Duplicate();
t.ssValid = (ST_b453bea0930035904f55a74692afd3a8Structure)this.ssValid.Duplicate();
t.ssBinary = this.ssBinary;
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
if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
} else if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
} else if (head == "valid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Valid")) variable.Value = ssValid; else variable.Optimized = true;
variable.SetFieldName("valid");
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
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
if (key == IdOrderContractFile) {
return ssOrderContractFile;
}
if (key == IdOrderFile) {
return ssOrderFile;
}
if (key == IdValid) {
return ssValid;
}
if (key == IdBinary) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssOrderContractFile;
}
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssOrderFile;
}
if (attributeKey == IdValid.Key.AsGuid) {
return ssValid;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
ssOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
ssValid.FillFromOther((IRecord) other.AttributeGet(IdValid));
ssBinary = (byte[]) other.AttributeGet(IdBinary);
}
} // ST_c3df6a1f053620bf8d50da58ff4e41bcStructure
/// <summary>
/// RecordList type <code>OrderFileTypesStructList</code> that represents a record list of
///  <code>OrderFileTypesStruct</code>
/// </summary>
public partial class RL_3d745491e03d6d19ccc0e1b33a371ccc : GenericRecordList<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure>, IEnumerable, IEnumerator {

protected override ST_c3df6a1f053620bf8d50da58ff4e41bcStructure GetElementDefaultValue() {
return new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();
}

public T[] ToArray<T>(Func<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d745491e03d6d19ccc0e1b33a371ccc recordList, Func<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d745491e03d6d19ccc0e1b33a371ccc(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure[] array) {
  RL_3d745491e03d6d19ccc0e1b33a371ccc result = new RL_3d745491e03d6d19ccc0e1b33a371ccc();
result.InnerFromArray(array);
    return result;
}

public static RL_3d745491e03d6d19ccc0e1b33a371ccc ToList<T>(T[] array, Func <T, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> converter) {
  RL_3d745491e03d6d19ccc0e1b33a371ccc result = new RL_3d745491e03d6d19ccc0e1b33a371ccc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d745491e03d6d19ccc0e1b33a371ccc FromRestList<T>(RestList<T> restList, Func <T, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> converter) {
  RL_3d745491e03d6d19ccc0e1b33a371ccc result = new RL_3d745491e03d6d19ccc0e1b33a371ccc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d745491e03d6d19ccc0e1b33a371ccc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(14,false);
def[1] = new BitArray(8,false);
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> NewList() {
return new RL_3d745491e03d6d19ccc0e1b33a371ccc();
}


} // RL_3d745491e03d6d19ccc0e1b33a371ccc
}

