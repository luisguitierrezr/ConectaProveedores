namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_4H3oe32iE2XaL7QdDYqvQ)
///  <code>RC_2cd5474bded5833e5b006a17fe1ba636</code> that represent
/// s <code>OrderContractFileOrderMainOrderFileStorageSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderContractFileOrderMainOrderFileStorageSupplierRecord
public partial struct RC_2cd5474bded5833e5b006a17fe1ba636 : ITypedRecord<RC_2cd5474bded5833e5b006a17fe1ba636> {
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ls24vaMN4urxcJQolfKjrA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NUo5p8E99rc2qs7SCeZhFg");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_2cd5474bded5833e5b006a17fe1ba636() {
OptimizedAttributes = null;
ssENOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENOrderContractFile.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENOrderFile.OptimizedAttributes = value[2];
    ssENStorage.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENOrderContractFile.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENOrderFile.OptimizedAttributes;
    all[3] = ssENStorage.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderContractFile.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderFile.Read( r, ref index);
ssENStorage.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_2cd5474bded5833e5b006a17fe1ba636 r) {
this = r;
}


public static bool operator == (RC_2cd5474bded5833e5b006a17fe1ba636 a, RC_2cd5474bded5833e5b006a17fe1ba636 b) {
if (a.ssENOrderContractFile != b.ssENOrderContractFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderFile != b.ssENOrderFile) return false;
if (a.ssENStorage != b.ssENStorage) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_2cd5474bded5833e5b006a17fe1ba636 a, RC_2cd5474bded5833e5b006a17fe1ba636 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2cd5474bded5833e5b006a17fe1ba636)) return false;
return (this == (RC_2cd5474bded5833e5b006a17fe1ba636)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderContractFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderFile.GetHashCode()
 ^ ssENStorage.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderContractFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderFile.RecursiveReset();
ssENStorage.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderContractFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderFile.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_2cd5474bded5833e5b006a17fe1ba636 Duplicate() {
RC_2cd5474bded5833e5b006a17fe1ba636 t;
t.ssENOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFile.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFile.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssENOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssENOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
return ssENOrderContractFile;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderFile) {
return ssENOrderFile;
}
if (key == IdStorage) {
return ssENStorage;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssENOrderContractFile;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssENOrderFile;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_2cd5474bded5833e5b006a17fe1ba636
/// <summary>
/// RecordList type <code>OrderContractFileOrderMainOrderFileStorageSupplierRecordList</code> that
///  represents a record list of <code>OrderContractFile, OrderMain, OrderFile, Storage
/// , Supplier</code>
/// </summary>
public partial class RL_2ee5e32f7cbdd7ae81465087ec05e535 : GenericRecordList<RC_2cd5474bded5833e5b006a17fe1ba636>, IEnumerable, IEnumerator {

protected override RC_2cd5474bded5833e5b006a17fe1ba636 GetElementDefaultValue() {
return new RC_2cd5474bded5833e5b006a17fe1ba636();
}

public T[] ToArray<T>(Func<RC_2cd5474bded5833e5b006a17fe1ba636, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2ee5e32f7cbdd7ae81465087ec05e535 recordList, Func<RC_2cd5474bded5833e5b006a17fe1ba636, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2ee5e32f7cbdd7ae81465087ec05e535(RC_2cd5474bded5833e5b006a17fe1ba636[] array) {
  RL_2ee5e32f7cbdd7ae81465087ec05e535 result = new RL_2ee5e32f7cbdd7ae81465087ec05e535();
result.InnerFromArray(array);
    return result;
}

public static RL_2ee5e32f7cbdd7ae81465087ec05e535 ToList<T>(T[] array, Func <T, RC_2cd5474bded5833e5b006a17fe1ba636> converter) {
  RL_2ee5e32f7cbdd7ae81465087ec05e535 result = new RL_2ee5e32f7cbdd7ae81465087ec05e535();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2ee5e32f7cbdd7ae81465087ec05e535 FromRestList<T>(RestList<T> restList, Func <T, RC_2cd5474bded5833e5b006a17fe1ba636> converter) {
  RL_2ee5e32f7cbdd7ae81465087ec05e535 result = new RL_2ee5e32f7cbdd7ae81465087ec05e535();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2ee5e32f7cbdd7ae81465087ec05e535() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(14,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2cd5474bded5833e5b006a17fe1ba636> NewList() {
return new RL_2ee5e32f7cbdd7ae81465087ec05e535();
}


} // RL_2ee5e32f7cbdd7ae81465087ec05e535
}

