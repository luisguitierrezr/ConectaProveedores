namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (HCDoT7O5JUWoTPjAtZ0Elg)
///  <code>RC_8c4427441293dc27b4cc40905a444588</code> that represent
/// s <code>OrderRequestFileOrderMainSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileOrderMainSupplierRecord
public partial struct RC_8c4427441293dc27b4cc40905a444588 : ITypedRecord<RC_8c4427441293dc27b4cc40905a444588> {
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_8c4427441293dc27b4cc40905a444588() {
OptimizedAttributes = null;
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(17,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderRequestFile.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENSupplier.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderRequestFile.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFile.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_8c4427441293dc27b4cc40905a444588 r) {
this = r;
}


public static bool operator == (RC_8c4427441293dc27b4cc40905a444588 a, RC_8c4427441293dc27b4cc40905a444588 b) {
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_8c4427441293dc27b4cc40905a444588 a, RC_8c4427441293dc27b4cc40905a444588 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8c4427441293dc27b4cc40905a444588)) return false;
return (this == (RC_8c4427441293dc27b4cc40905a444588)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_8c4427441293dc27b4cc40905a444588 Duplicate() {
RC_8c4427441293dc27b4cc40905a444588 t;
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_8c4427441293dc27b4cc40905a444588
/// <summary>
/// RecordList type <code>OrderRequestFileOrderMainSupplierRecordList</code> that represents a record
///  list of <code>OrderRequestFile, OrderMain, Supplier</code>
/// </summary>
public partial class RL_39842304b010e66ad38d0f73c466d0e1 : GenericRecordList<RC_8c4427441293dc27b4cc40905a444588>, IEnumerable, IEnumerator {

protected override RC_8c4427441293dc27b4cc40905a444588 GetElementDefaultValue() {
return new RC_8c4427441293dc27b4cc40905a444588();
}

public T[] ToArray<T>(Func<RC_8c4427441293dc27b4cc40905a444588, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39842304b010e66ad38d0f73c466d0e1 recordList, Func<RC_8c4427441293dc27b4cc40905a444588, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39842304b010e66ad38d0f73c466d0e1(RC_8c4427441293dc27b4cc40905a444588[] array) {
  RL_39842304b010e66ad38d0f73c466d0e1 result = new RL_39842304b010e66ad38d0f73c466d0e1();
result.InnerFromArray(array);
    return result;
}

public static RL_39842304b010e66ad38d0f73c466d0e1 ToList<T>(T[] array, Func <T, RC_8c4427441293dc27b4cc40905a444588> converter) {
  RL_39842304b010e66ad38d0f73c466d0e1 result = new RL_39842304b010e66ad38d0f73c466d0e1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39842304b010e66ad38d0f73c466d0e1 FromRestList<T>(RestList<T> restList, Func <T, RC_8c4427441293dc27b4cc40905a444588> converter) {
  RL_39842304b010e66ad38d0f73c466d0e1 result = new RL_39842304b010e66ad38d0f73c466d0e1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39842304b010e66ad38d0f73c466d0e1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(17,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8c4427441293dc27b4cc40905a444588> NewList() {
return new RL_39842304b010e66ad38d0f73c466d0e1();
}


} // RL_39842304b010e66ad38d0f73c466d0e1
}

