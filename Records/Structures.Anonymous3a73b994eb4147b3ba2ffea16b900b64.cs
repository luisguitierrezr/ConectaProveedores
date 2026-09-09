namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lLlzOkHrs0e6L_6ha5ALZA)
///  <code>RC_5ad46beda6daded312a458bcd914266d</code> that represent
/// s <code>OrderMainSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainSupplierRegionRecord
public partial struct RC_5ad46beda6daded312a458bcd914266d : ITypedRecord<RC_5ad46beda6daded312a458bcd914266d> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_5ad46beda6daded312a458bcd914266d() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(28,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_5ad46beda6daded312a458bcd914266d r) {
this = r;
}


public static bool operator == (RC_5ad46beda6daded312a458bcd914266d a, RC_5ad46beda6daded312a458bcd914266d b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_5ad46beda6daded312a458bcd914266d a, RC_5ad46beda6daded312a458bcd914266d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5ad46beda6daded312a458bcd914266d)) return false;
return (this == (RC_5ad46beda6daded312a458bcd914266d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_5ad46beda6daded312a458bcd914266d Duplicate() {
RC_5ad46beda6daded312a458bcd914266d t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_5ad46beda6daded312a458bcd914266d
/// <summary>
/// RecordList type <code>OrderMainSupplierRegionRecordList</code> that represents a record list of
///  <code>OrderMain, Supplier, Region</code>
/// </summary>
public partial class RL_a5d34dadc1b2a091bffaa2b834b2d48d : GenericRecordList<RC_5ad46beda6daded312a458bcd914266d>, IEnumerable, IEnumerator {

protected override RC_5ad46beda6daded312a458bcd914266d GetElementDefaultValue() {
return new RC_5ad46beda6daded312a458bcd914266d();
}

public T[] ToArray<T>(Func<RC_5ad46beda6daded312a458bcd914266d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a5d34dadc1b2a091bffaa2b834b2d48d recordList, Func<RC_5ad46beda6daded312a458bcd914266d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a5d34dadc1b2a091bffaa2b834b2d48d(RC_5ad46beda6daded312a458bcd914266d[] array) {
  RL_a5d34dadc1b2a091bffaa2b834b2d48d result = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
result.InnerFromArray(array);
    return result;
}

public static RL_a5d34dadc1b2a091bffaa2b834b2d48d ToList<T>(T[] array, Func <T, RC_5ad46beda6daded312a458bcd914266d> converter) {
  RL_a5d34dadc1b2a091bffaa2b834b2d48d result = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a5d34dadc1b2a091bffaa2b834b2d48d FromRestList<T>(RestList<T> restList, Func <T, RC_5ad46beda6daded312a458bcd914266d> converter) {
  RL_a5d34dadc1b2a091bffaa2b834b2d48d result = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a5d34dadc1b2a091bffaa2b834b2d48d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(29,false);
def[1] = new BitArray(28,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5ad46beda6daded312a458bcd914266d> NewList() {
return new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
}


} // RL_a5d34dadc1b2a091bffaa2b834b2d48d
}

