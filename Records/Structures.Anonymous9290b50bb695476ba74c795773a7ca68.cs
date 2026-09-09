namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (C7WQkpW2a0enTHlXc6fKaA)
///  <code>RC_041cacb77c43fb5e1fc788222594e8fd</code> that represent
/// s <code>OrderContractFinanceFileOrderFinanceFileRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderContractFinanceFileOrderFinanceFileRecord
public partial struct RC_041cacb77c43fb5e1fc788222594e8fd : ITypedRecord<RC_041cacb77c43fb5e1fc788222594e8fd> {
internal static readonly GlobalObjectKey IdOrderContractFinanceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZzwM4GHTbJkf6uWlxepguA");
internal static readonly GlobalObjectKey IdOrderFinanceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Xm_YVH9x5mb2h+RiicHMJg");

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFinanceFile;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFinanceFile;


public BitArray OptimizedAttributes;

public RC_041cacb77c43fb5e1fc788222594e8fd() {
OptimizedAttributes = null;
ssENOrderContractFinanceFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderFinanceFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderContractFinanceFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderFinanceFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderContractFinanceFile.OptimizedAttributes = value[0];
    ssENOrderFinanceFile.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderContractFinanceFile.OptimizedAttributes;
    all[1] = ssENOrderFinanceFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderContractFinanceFile.Read( r, ref index);
ssENOrderFinanceFile.Read( r, ref index);
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
public void ReadIM(RC_041cacb77c43fb5e1fc788222594e8fd r) {
this = r;
}


public static bool operator == (RC_041cacb77c43fb5e1fc788222594e8fd a, RC_041cacb77c43fb5e1fc788222594e8fd b) {
if (a.ssENOrderContractFinanceFile != b.ssENOrderContractFinanceFile) return false;
if (a.ssENOrderFinanceFile != b.ssENOrderFinanceFile) return false;
return true;
}

public static bool operator != (RC_041cacb77c43fb5e1fc788222594e8fd a, RC_041cacb77c43fb5e1fc788222594e8fd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_041cacb77c43fb5e1fc788222594e8fd)) return false;
return (this == (RC_041cacb77c43fb5e1fc788222594e8fd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderContractFinanceFile.GetHashCode()
 ^ ssENOrderFinanceFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderContractFinanceFile.RecursiveReset();
ssENOrderFinanceFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderContractFinanceFile.InternalRecursiveSave();
ssENOrderFinanceFile.InternalRecursiveSave();
}


public RC_041cacb77c43fb5e1fc788222594e8fd Duplicate() {
RC_041cacb77c43fb5e1fc788222594e8fd t;
t.ssENOrderContractFinanceFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFinanceFile.Duplicate();
t.ssENOrderFinanceFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFinanceFile.Duplicate();
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
if (head == "ordercontractfinancefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFinanceFile")) variable.Value = ssENOrderContractFinanceFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfinancefile");
} else if (head == "orderfinancefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFinanceFile")) variable.Value = ssENOrderFinanceFile; else variable.Optimized = true;
variable.SetFieldName("orderfinancefile");
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
if (key == IdOrderContractFinanceFile) {
return ssENOrderContractFinanceFile;
}
if (key == IdOrderFinanceFile) {
return ssENOrderFinanceFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderContractFinanceFile.Key.AsGuid) {
return ssENOrderContractFinanceFile;
}
if (attributeKey == IdOrderFinanceFile.Key.AsGuid) {
return ssENOrderFinanceFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderContractFinanceFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFinanceFile));
ssENOrderFinanceFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFinanceFile));
}
} // RC_041cacb77c43fb5e1fc788222594e8fd
/// <summary>
/// RecordList type <code>OrderContractFinanceFileOrderFinanceFileRecordList</code> that represents a
///  record list of <code>OrderContractFile, OrderFile</code>
/// </summary>
public partial class RL_eeab316051f92c8094cbc73a8650f55b : GenericRecordList<RC_041cacb77c43fb5e1fc788222594e8fd>, IEnumerable, IEnumerator {

protected override RC_041cacb77c43fb5e1fc788222594e8fd GetElementDefaultValue() {
return new RC_041cacb77c43fb5e1fc788222594e8fd();
}

public T[] ToArray<T>(Func<RC_041cacb77c43fb5e1fc788222594e8fd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eeab316051f92c8094cbc73a8650f55b recordList, Func<RC_041cacb77c43fb5e1fc788222594e8fd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eeab316051f92c8094cbc73a8650f55b(RC_041cacb77c43fb5e1fc788222594e8fd[] array) {
  RL_eeab316051f92c8094cbc73a8650f55b result = new RL_eeab316051f92c8094cbc73a8650f55b();
result.InnerFromArray(array);
    return result;
}

public static RL_eeab316051f92c8094cbc73a8650f55b ToList<T>(T[] array, Func <T, RC_041cacb77c43fb5e1fc788222594e8fd> converter) {
  RL_eeab316051f92c8094cbc73a8650f55b result = new RL_eeab316051f92c8094cbc73a8650f55b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eeab316051f92c8094cbc73a8650f55b FromRestList<T>(RestList<T> restList, Func <T, RC_041cacb77c43fb5e1fc788222594e8fd> converter) {
  RL_eeab316051f92c8094cbc73a8650f55b result = new RL_eeab316051f92c8094cbc73a8650f55b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eeab316051f92c8094cbc73a8650f55b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_041cacb77c43fb5e1fc788222594e8fd> NewList() {
return new RL_eeab316051f92c8094cbc73a8650f55b();
}


} // RL_eeab316051f92c8094cbc73a8650f55b
}

