namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_EM3 (UAJuilwVeU6ttLqBewB1kA)
///  <code>ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure</code> that represents <code>PI_ITEM_EM3</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM3
public partial struct ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure : ITypedRecord<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*ienwdkQPUk2rn9z+t2wk6g");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Ud6wsiYwYUizQlZrO5kHCw");
internal static readonly GlobalObjectKey IdCANTIDAD_ENTRADA = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*9t4HTYUK0kaXzCNQEeptiA");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*PIKs+9TfxkeDI_dZ9DwaYg");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*iXqkwPUeH0a0nHE3RuA6QA");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*jHK8fGgCJ0m0RV7lE64pUQ");

public int ssPOSICION_PEDIDO;

public string ssMATERIAL;

public decimal ssCANTIDAD_ENTRADA;

public string ssCENTRO;

public string ssALMACEN;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = -2147483648;
ssMATERIAL = "";
ssCANTIDAD_ENTRADA = -79228162514264337593543950335m;
ssCENTRO = "";
ssALMACEN = "";
ssTEXTO_POSICION = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPOSICION_PEDIDO = r.ReadInteger(index++, "PI_ITEM_EM3.POSICION_PEDIDO", 0);
ssMATERIAL = r.ReadText(index++, "PI_ITEM_EM3.MATERIAL", "");
ssCANTIDAD_ENTRADA = r.ReadDecimal(index++, "PI_ITEM_EM3.CANTIDAD_ENTRADA", 0.0M);
ssCENTRO = r.ReadText(index++, "PI_ITEM_EM3.CENTRO", "");
ssALMACEN = r.ReadText(index++, "PI_ITEM_EM3.ALMACEN", "");
ssTEXTO_POSICION = r.ReadText(index++, "PI_ITEM_EM3.TEXTO_POSICION", "");
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
public void ReadIM(ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure r) {
this = r;
}


public static bool operator == (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure a, ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_ENTRADA != b.ssCANTIDAD_ENTRADA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure a, ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure)) return false;
return (this == (ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_ENTRADA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure Duplicate() {
ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_ENTRADA = this.ssCANTIDAD_ENTRADA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
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
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "cantidad_entrada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_ENTRADA")) variable.Value = ssCANTIDAD_ENTRADA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
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
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCANTIDAD_ENTRADA) {
return ssCANTIDAD_ENTRADA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCANTIDAD_ENTRADA.Key.AsGuid) {
return ssCANTIDAD_ENTRADA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (int) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_ENTRADA = (decimal) other.AttributeGet(IdCANTIDAD_ENTRADA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure
/// <summary>
/// RecordList type <code>PI_ITEM_EM3List</code> that represents a record list of
///  <code>PI_ITEM_EM3</code>
/// </summary>
public partial class RL_7467e78eb931d55f4ebaca0d0fac8a6d : GenericRecordList<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure>, IEnumerable, IEnumerator {

protected override ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure GetElementDefaultValue() {
return new ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure();
}

public T[] ToArray<T>(Func<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7467e78eb931d55f4ebaca0d0fac8a6d recordList, Func<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7467e78eb931d55f4ebaca0d0fac8a6d(ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure[] array) {
  RL_7467e78eb931d55f4ebaca0d0fac8a6d result = new RL_7467e78eb931d55f4ebaca0d0fac8a6d();
result.InnerFromArray(array);
    return result;
}

public static RL_7467e78eb931d55f4ebaca0d0fac8a6d ToList<T>(T[] array, Func <T, ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> converter) {
  RL_7467e78eb931d55f4ebaca0d0fac8a6d result = new RL_7467e78eb931d55f4ebaca0d0fac8a6d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7467e78eb931d55f4ebaca0d0fac8a6d FromRestList<T>(RestList<T> restList, Func <T, ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> converter) {
  RL_7467e78eb931d55f4ebaca0d0fac8a6d result = new RL_7467e78eb931d55f4ebaca0d0fac8a6d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7467e78eb931d55f4ebaca0d0fac8a6d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> NewList() {
return new RL_7467e78eb931d55f4ebaca0d0fac8a6d();
}


} // RL_7467e78eb931d55f4ebaca0d0fac8a6d
}

